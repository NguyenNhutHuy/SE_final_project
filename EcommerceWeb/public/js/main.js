
const state = {
    cart: [],
    total: 0
}

if (sessionStorage.getItem('state-cart-info')) {
    state.cart = JSON.parse(sessionStorage.getItem('state-cart-info'))
}

const formatter = new Intl.NumberFormat('en-US', {
    style: 'currency',
    currency: 'USD'
});


function loadData() {
    if (document.querySelector('#cartContent')) {
        state.total = computeTotal(state.cart)
        document.querySelector('#total_area').innerHTML = formatter.format(state.total)

        var html = `
        <tr class="header">
            <td></td>
            <td>Product ID</td>
            <td>Product name</td>
            <td>Available</td>
            <td>Price</td>
            <td>Order quantity</td>
            <td></td>
        </tr>
        `

        for (let index = 0; index < state.cart.length; index++) {
            const item = state.cart[index];

            html += `
                <tr>
                    <td>
                        <img class="isCss" src="${item.productImage}">
                    </td>
                    <td>${item.productID}</td>
                    <td>${item.productName}</td>
                    <td>${item.productQuantity}</td>
                    <td>${item.price}</td>
                    <td>
                        <div class="input-group">
                            <input style="width: 50px;" data-id="${item.productID}" data-price="${item.price}" min="0" max="${item.productQuantity}" type="number" value="${item.quantity}" class="form-control quantity-to-buy">
                        </div>
                    </td>
                    <td>
                        <button data-id="${item.productID}" class="btn btn-danger click-to-delete-form-cart">Delete</button>
                    </td>
                </tr>
            `
        }

        if (state.cart.length) {
            document.querySelector('#cartContent').innerHTML = html
        } else {
            document.querySelector('#cartContent').innerHTML = `
                                                    <tr style="border: none;">
                                                        <td style="border: none;">(Trống)</td>
                                                    </tr>
                                                `
        }
    }
}

loadData()

document.querySelector('#showNumberItemInCart').innerHTML = computeNum(state.cart);

document.onclick = (e) => {
    if (e.target.id === 'btn_order') {
        var order_item = JSON.parse(sessionStorage.getItem('state-cart-info'))
        if (order_item && order_item.length) {
            var orderInfor = {
                order_item,
                paymentMethod: document.querySelector('input[name="paymentMenthod"]:checked').value,
                Fullname: document.querySelector('#fullname').value,
                address: document.querySelector('#deliveryAddress').value,
                phoneNumber: document.querySelector('#phoneNumber').value
            }
            fetch('/orderProduct',{
                method: 'POST',
                cache: 'no-cache',
                headers: {
                    'Content-Type': 'application/json'
                    // 'Content-Type': 'application/x-www-form-urlencoded',
                },
                body: JSON.stringify(orderInfor)
            })
                .then((res) => res.json())
                .then(data => {
                    if (data.status === 'success') {
                        console.log('oke api')
                        sessionStorage.clear()
                        location.href = ('http://localhost:3030/orderSuccess')
                    } else {
                        console.log('error api')
                    }
                });
        } else{
            alert("cart is empty")
        }
    }

    if (e.target.className === 'btn btn-danger click-to-delete-form-cart') {

        for (let index = 0; index < state.cart.length; index++) {
            const infoItem = state.cart[index];
            if (infoItem.productID === e.target.getAttribute('data-id')) {
                state.cart.splice(index, 1)
                sessionStorage.setItem('state-cart-info', JSON.stringify(state.cart))
                document.querySelector('#showNumberItemInCart').innerHTML = computeNum(state.cart);
                loadData();
            }
        }
    }

    if (e.target.className.includes('click-to-buy-now')) {
        e.preventDefault()
        var productID = e.target.getAttribute('data-id');
        var price = e.target.getAttribute('data-price');

        var infoItem = {
            productID,
            price,
            quantity: '1',
            productName: e.target.getAttribute('data-name'),
            productImage: e.target.getAttribute('data-image'),
            productQuantity: e.target.getAttribute('data-quantity'),
        }

        var checkIsExist = false
        for (let index = 0; index < state.cart.length; index++) {
            const item = state.cart[index];
            if (item.productID === infoItem.productID) {
                checkIsExist = true
                state.cart[index].quantity += infoItem.quantity
            }
        }

        if (!checkIsExist) {
            state.cart.push(infoItem)
        }

        sessionStorage.setItem('state-cart-info', JSON.stringify(state.cart))

        document.querySelector('#showNumberItemInCart').innerHTML = computeNum(state.cart);
        alert('đã thêm vào giỏ hàng')
    }
}

document.onchange = (e) => {
    if (e.target.className == 'form-control quantity-to-buy') {
        for (let index = 0; index < state.cart.length; index++) {
            const infoItem = state.cart[index];
            if (infoItem.productID === e.target.getAttribute('data-id')) {
                state.cart[index].quantity = e.target.value
            }
        }
        var priceItem = Number(e.target.getAttribute('data-price'))
        console.log(priceItem)

        state.total = computeTotal(state.cart)
        document.querySelector('#total_area').innerHTML = formatter.format(state.total)

        document.querySelector('#showNumberItemInCart').innerHTML = computeNum(state.cart);
        sessionStorage.setItem('state-cart-info', JSON.stringify(state.cart))

        console.log(state.cart)
        console.log(state.total)
    }
}

function computeTotal(cart) {
    var total = 0

    for (let index = 0; index < cart.length; index++) {
        const item = cart[index];
        total += Number(item.quantity) * Number(item.price)
    }

    return total
}

function computeNum(cart) {
    var numberOf = 0

    for (let index = 0; index < cart.length; index++) {
        const item = cart[index];
        numberOf += Number(item.quantity)
    }

    return numberOf
}

