const express = require('express')
const { engine } = require('express-handlebars')
const PORT = process.env.PORT || 3030

const app = express()
app.use(express.json());
app.use(express.urlencoded());

app.use(express.static(__dirname + '/public'))

app.engine('.hbs', engine({
    extname: '.hbs'
}))
app.set('view engine', '.hbs')

app.get('/', async (req, res) => {
    const sql = require('mssql/msnodesqlv8')

    const pool = new sql.ConnectionPool({
        database: 'SupplementFactsCompany',
        server: 'DESKTOP-HSF2Q6J\\SQLEXPRESS',
        driver: 'msnodesqlv8',
        options: {
            trustedConnection: true
        }
    })

    pool.connect().then(() => {
        //simple query
        pool.request().query("SELECT * FROM tb_SFProcucts WHERE tb_SFProcucts.quantity>0 AND isBussiness='on'", (err, result) => {
            res.render('home', { products: result.recordset })
        })
    })
})


app.get('/Cart', async (req, res) => {
    res.render('cart')
})

app.get('/orderSuccess', (req, res) => {
    res.render('orderSuccess')
})

app.post('/orderProduct',  async (req, res) => {
    const {paymentMethod, Fullname, address, phoneNumber, order_item} = req.body
    var numberCusOrder = await getNumberCustomerOrder()
    var invoiceID = "CO#" + (numberCusOrder + 1)

    await createNewCustomerOrder(invoiceID, paymentMethod, address, phoneNumber, 'waiting confirm', Fullname)

    for (let index = 0; index < order_item.length; index++) {
        const item = order_item[index];
        await updateMinusProduct(item.productID, Number(item.quantity))
        await createNewCustomerOrderDetail(index + 1, Number(item.quantity), Number(item.price), invoiceID, item.productID)
    }

    return res.json({status: 'success'})
})

function createNewCustomerOrderDetail(invoiceDetailID, quantity, agentPrice, invoiceID, productID) {
    return new Promise((resolve, reject) => {
        const sql = require('mssql/msnodesqlv8')

        const pool = new sql.ConnectionPool({
            database: 'SupplementFactsCompany',
            server: 'DESKTOP-HSF2Q6J\\SQLEXPRESS',
            driver: 'msnodesqlv8',
            options: {
                trustedConnection: true
            }
        })
    
        pool.connect().then(() => {
            //simple query
            pool.request().query(`INSERT INTO 
                        tb_CustomerInvoiceDetail(invoiceDetailID, quantity, agentPrice, invoiceID, productID)
                        VALUES ('${invoiceDetailID}', '${quantity}', '${agentPrice}', '${invoiceID}', '${productID}')`, (err, result) => {
                resolve(result)
            })
        })
    }) 
}

function updateMinusProduct(productID, quantity) {
    return new Promise((resolve, reject) => {
        const sql = require('mssql/msnodesqlv8')

        const pool = new sql.ConnectionPool({
            database: 'SupplementFactsCompany',
            server: 'DESKTOP-HSF2Q6J\\SQLEXPRESS',
            driver: 'msnodesqlv8',
            options: {
                trustedConnection: true
            }
        })
    
        pool.connect().then(() => {
            //simple query
            pool.request().query(`UPDATE tb_SFProcucts
                                SET tb_SFProcucts.quantity = tb_SFProcucts.quantity - ${quantity}
                                WHERE tb_SFProcucts.productID='${productID}'`, (err, result) => {
                resolve(result)
            })
        })
    }) 
}

function createNewCustomerOrder(invoiceID, payment, address, customerPhoneNumber, status, Fullname) {
    return new Promise((resolve, reject) => {
        const sql = require('mssql/msnodesqlv8')

        const pool = new sql.ConnectionPool({
            database: 'SupplementFactsCompany',
            server: 'DESKTOP-HSF2Q6J\\SQLEXPRESS',
            driver: 'msnodesqlv8',
            options: {
                trustedConnection: true
            }
        })
    
        pool.connect().then(() => {
            //simple query
            pool.request().query(`INSERT INTO 
                        tb_CustomerInvoices(invoiceID, OrderDate, payment, address, customerPhoneNumber, status, Fullname)
                        VALUES ('${invoiceID}', GETDATE(), '${payment}', '${address}', '${customerPhoneNumber}', '${status}', '${Fullname}')`, (err, result) => {
                resolve(result)
            })
        })
    }) 
}

function getNumberCustomerOrder() {
    return new Promise((resolve, reject) => {
        const sql = require('mssql/msnodesqlv8')

        const pool = new sql.ConnectionPool({
            database: 'SupplementFactsCompany',
            server: 'DESKTOP-HSF2Q6J\\SQLEXPRESS',
            driver: 'msnodesqlv8',
            options: {
                trustedConnection: true
            }
        })
    
        pool.connect().then(() => {
            //simple query
            pool.request().query(`SELECT COUNT(tb_CustomerInvoices.invoiceID) FROM tb_CustomerInvoices `, (err, result) => {
                resolve(result.recordset[0][''])
            })
        })
    }) 
}

app.listen(PORT, () => {
    console.log('http://localhost:3030')
})