import { SET_OTP, VERIFY_OTP,All_PRODUCTS, PRODUCT_BY_ID, DESCRIPTIONS_BY_ID, COLORS_BY_ID, SIZES_BY_ID, ADDED_CART_ITEMS } from "./Types";
const axios = require('axios');


export const loginUser = (data) => dispatch => {
    var headers = {
        'Content-Type': 'application/json'
    }
    var params = {
        email: data
    }
    axios.post("https://localhost:44380/api/Product/requestOTP", null, { params: params, headers: headers })
        .then(res => {
            dispatch({ type: SET_OTP, payload: res })
        })
        .catch(error => {
            console.log("error while sending otp" + error)
        });
};

export const VerifyOtp = (data) => dispatch => {
    var headers = {
        'Content-Type': 'application/json'
    }
    axios.post("https://localhost:44380/api/Product/verifyOTP", data, { headers: headers })
        .then(res => {
            dispatch({ type: VERIFY_OTP, payload: res })
        })
        .catch(error => {
            console.log("error while sending otp" + error)
        });
};

export const GetAllItems = () => dispatch => {
    var headers = {
        'Content-Type': 'application/json'
    }
    axios.get("https://localhost:44380/api/Product/getItems",{ headers: headers })
        .then(res => {
            dispatch({ type: All_PRODUCTS, payload: res })
        })
        .catch(error => {
            console.log("error while sending otp" + error)
        });
};

export const GetItemById = (data) => dispatch => {
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        id:data
    }
    axios.get("https://localhost:44380/api/Product/getItemsById", { params: params }, { headers: headers })
        .then(res => {
            dispatch({ type: PRODUCT_BY_ID, payload: res })
        })
        .catch(error => {
            console.log("error while sending otp" + error)
        });
};

export const GetAllItemSizes = (data) => dispatch => {
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        id:data
    }
    axios.get("https://localhost:44380/api/Product/getSizeById",{params:params},{ headers: headers })
        .then(res => {
            dispatch({ type: SIZES_BY_ID, payload: res })
        })
        .catch(error => {
            console.log("error while sending otp" + error)
        });
};

export const GetAllItemColors = (data) => dispatch => {
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        id:data
    }
    axios.get("https://localhost:44380/api/Product/getColorById",{params:params},{ headers: headers })
        .then(res => {
            dispatch({ type: COLORS_BY_ID, payload: res })
        })
        .catch(error => {
            console.log("error while sending otp" + error)
        });
};

export const GetAllItemDescriptions = (data) => dispatch => {
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        id:data
    }
    axios.get("https://localhost:44380/api/Product/getDescriptionById",{params:params},{ headers: headers })
        .then(res => {
            dispatch({ type: DESCRIPTIONS_BY_ID, payload: res })
        })
        .catch(error => {
            console.log("error while sending otp" + error)
        });
};

export const AddSelectedItemToCart = (data) => dispatch => {
    var headers = {
        'Content-Type': 'application/json'
    }
    axios.post("https://localhost:44380/api/Product/addSelected",data,{ headers: headers })
        .then(res => {
            dispatch({ type: ADDED_CART_ITEMS, payload: res })
        })
        .catch(error => {
            console.log("error while sending otp" + error)
        });
};




