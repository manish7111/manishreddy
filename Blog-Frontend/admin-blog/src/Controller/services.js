const axios = require('axios');
export async function addProduct(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return await axios.post("https://localhost:44380/api/Product/addItems", data, { headers: headers })
            .then(response => {
                return response
            })

    }
    catch (error) {
        console.log("error while adding the product" + error)
        return Promise.resolve(false)
    }
}
export function getAllItems() {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.get("https://localhost:44380/api/Product/getItems",{ headers: headers })
            .then(response => {
                console.log('response data----->>>', response);
                return response
            })

    }
    catch (error) {
        console.log("error occured while fetching the products" + error)
        return Promise.resolve(false)

    }
}
export async function deleteProduct(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        id:data
    }
    try {
        return await axios.delete("https://localhost:44380/api/Product/deleteItems", { params: params }, { headers: headers })
            .then(response => {
                console.log('response data----->>>', response);
                return response
            })

    }
    catch (error) {
        console.log("error while deleting the product" + error)
        return Promise.resolve(false)
    }
}
export async function updateProduct(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return await axios.put("https://localhost:44380/api/Product/updateItems", data, { headers: headers })
            .then(response => {
                return response
            })

    }
    catch (error) {
        console.log("error while updating the product" + error)
        return Promise.resolve(false)
    }
}
export async function getProduct(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        id:data
    }
    try {
        return await axios.get("https://localhost:44380/api/Product/getItemsById", { params: params }, { headers: headers })
            .then(response => {
                return response
            })

    }
    catch (error) {
        console.log("error while getting the product" + error)
        return Promise.resolve(false)
    }
}
export async function addDescriptions(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return await axios.post("https://localhost:44380/api/Product/addDesc", data, { headers: headers })
            .then(response => {
                return response
            })
    }
    catch (error) {
        console.log("error while adding description to the product" + error)
        return Promise.resolve(false)
    }
}
export async function addSizes(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return await axios.post("https://localhost:44380/api/Product/addSizes", data, { headers: headers })
            .then(response => {
                return response
            })
    }
    catch (error) {
        console.log("error while adding Sizes to the product" + error)
        return Promise.resolve(false)
    }
}
export function getAllSizesById(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        id:data
    }
    try {
        return axios.get("https://localhost:44380/api/Product/getSizeById",{params:params},{ headers: headers })
            .then(response => {
                console.log('response data----->>>', response);
                return response
            })

    }
    catch (error) {
        console.log("error occured while fetching the products" + error)
        return Promise.resolve(false)

    }
}
export async function addColors(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return await axios.post("https://localhost:44380/api/Product/addColors", data, { headers: headers })
            .then(response => {
                return response
            })
    }
    catch (error) {
        console.log("error while adding Colors to the product" + error)
        return Promise.resolve(false)
    }
}
export function getAllColorsById(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        id:data
    }
    try {
        return axios.get("https://localhost:44380/api/Product/getColorById",{params:params},{ headers: headers })
            .then(response => {
                console.log('response data----->>>', response);
                return response
            })
    }
    catch (error) {
        console.log("error occured while fetching the products" + error)
        return Promise.resolve(false)

    }
}
export async function AddSelectedItemToCart(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return await axios.post("https://localhost:44380/api/Product/addSelected",data,{ headers: headers })
            .then(response => {
                console.log('response data----->>>', response);
                return response
            })
    }
    catch (error) {
        console.log("error occured while adding the products to cart" + error)
        return Promise.resolve(false)

    }
}

export function getDescriptionById(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        id:data
    }
    try {
        return axios.get("https://localhost:44380/api/Product/getDescriptionById",{params:params},{ headers: headers })
            .then(response => {
                console.log('response data----->>>', response);
                return response
            })

    }
    catch (error) {
        console.log("error occured while fetching the products" + error)
        return Promise.resolve(false)

    }
}

export function cartProducts(data) {
    var params={
        email:data
    }
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.get("https://localhost:44380/api/Product/getselected",{params:params},{ headers: headers })
            .then(response => {
                console.log('response data----->>>', response);
                return response
            })

    }
    catch (error) {
        console.log("error occured while fetching the products" + error)
        return Promise.resolve(false)

    }
}
export async function removeFromCart(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        id:data
    }
    try {
        return await axios.delete("https://localhost:44380/api/Product/deleteSelected", { params: params }, { headers: headers })
            .then(response => {
                console.log('response data----->>>', response);
                return response
            })

    }
    catch (error) {
        console.log("error while deleting the product" + error)
        return Promise.resolve(false)
    }
}
////login

export async function login(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        email:data
    }
    console.log(params,"otp")
    try {
        return await axios.post("https://localhost:44380/api/Product/requestOTP", null, {params:params, headers: headers })
            .then(response => {
                console.log('response data for otp----->>>', response);
                return response

            })
    }
    catch (error) {
        console.log("error while sending otp" + error)
        return Promise.resolve(false)
    }
}
export async function VerifyOTP(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return await axios.post("https://localhost:44380/api/Product/verifyOTP", data, { headers: headers })
            .then(response => {
                console.log('response data for otp----->>>', response);
                return response

            })
    }
    catch (error) {
        console.log("error while sending otp" + error)
        return Promise.resolve(false)
    }
}
export async function addAddress(data) {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return await axios.post("https://localhost:44380/api/Product/addAddress", data, { headers: headers })
            .then(response => {
                return response
            })
    }
    catch (error) {
        console.log("error while adding address" + error)
        return Promise.resolve(false)
    }
}
export function getAddress(data) {
    var params={
        email:data
    }
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.get("https://localhost:44380/api/Product/getAddress",{params:params},{ headers: headers })
            .then(response => {
                console.log('response data----->>>', response);
                return response
            })
    }
    catch (error) {
        console.log("error occured while getting the address" + error)
        return Promise.resolve(false)

    }
}