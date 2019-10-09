const axios = require('axios');
export function addLabel(newUser) {
    console.log("new user",newUser.Email,newUser.Label);
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.post(`${process.env.REACT_APP_BASE_URL}/label`, newUser, { headers: headers })
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
export function getLabel(newUser) {
    console.log("new user",newUser);
    var params={
        Email:newUser
    }
    console.log("---------->>>>>>>>>>>>>???",params);
    
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.get(`${process.env.REACT_APP_BASE_URL}/getlabel`, {params:params}, { headers: headers })
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
export function editLabel(newUser) {
    console.log("new user",newUser);
    var params={
        Id:newUser.Id,
        Label:newUser.Label
    }
    console.log("---------->>>>>>>>>>>>>???",params);
    
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.put(`${process.env.REACT_APP_BASE_URL}/updatelabel`, {params:params}, { headers: headers })
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
export function deleteLabel(newUser) {
    console.log("new user",newUser);
    var params={
        id:newUser.Id
    }
    console.log("---------->>>>>>>>>>>>>???",params);
    
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.delete(`${process.env.REACT_APP_BASE_URL}/deletelabel`, {params:params}, { headers: headers })
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
export function getLabelByLabel(newUser) {
    console.log("new user",newUser);
    var params={
        Label:newUser
    }
    console.log("---------->>>>>>>>>>>>>???",params);
    
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.get(`${process.env.REACT_APP_BASE_URL}/getlabels`, {params:params}, { headers: headers })
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