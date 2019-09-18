/*****************************************************************************************************
 *  @Purpose        : Here we have to create the userServices that contains all required userServices functions.
 *  @file           : userServices.jsx       
 *  @author         : Manish Reddy
 *  @version        : v0.1
 *  @since          : 12-09-2019
 *****************************************************************************************************/

//calling axios function to connect with backend.
const axios = require('axios');
//userRegister is a function while getting the responce from the frontend and helps in mapping the data to backend.
export function userRegister(newUser) {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.post("https://localhost:44351/register", newUser, { headers: headers })
            .then(response => {
                console.log('response data----->>>', response);
                return response
            })

    }
    catch (error) {
        console.log("error in usectr--" + error)
        return Promise.resolve(false)

    }
}

//userSignIn is a function while getting the responce from the frontend and helps in mapping the data to backend.
export function userSignIn(newUser) {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.post("https://localhost:44351/login", newUser, { headers: headers })
            .then(response => {
                console.log('response data----->>>', response);
                return response
            })

    }
    catch (error) {
        console.log("error in usectr--" + error)
        return Promise.resolve(false)

    }
}

//userFbSignIn is a function while getting the responce from the frontend and helps in mapping the data to backend.
export function userFbSignIn(newUser) {
    console.log("new user",newUser.Email);
    
    var params = {
        Email:newUser.Email
    }
    try {
        return axios.post("https://localhost:44351/fblogin",newUser,{params:params})
            .then(response => {
                console.log('response data----->>>', response);
                return response
            })

    }
    catch (error) {
        console.log("error in usectr--" + error)
        return Promise.resolve(false)

    }
}




