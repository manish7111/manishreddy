const axios = require('axios');
export function userRegister(newUser) {
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.post("https://localhost:44351/adminregister", newUser, { headers: headers })
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
        return axios.post("https://localhost:44351/adminlogin", newUser, { headers: headers })
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


export function userForgetPassword(newUser) {
    console.log("new user", newUser.Email);

    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.post("https://localhost:44351/forget", newUser, { headers: headers })
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
export function userResetPassword(newUser) {
    console.log("new user", newUser.Email);

    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.post("https://192.168.1.136:44351/reset", newUser, { headers: headers })
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
export  async function profileUpload(data) {
    console.log("data of profile upload",data )
    var headers = {
        "Content-Type": "multipart/formdata"
    }  
    try {
        return await axios.post('https://localhost:44351/profileupload', data, { headers: headers })
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
export async function pushNOtification(){
    var headers={
        "Content-Type":"application/json",
        "Authorization":"key=AAAABWNyTkE:APA91bEgAw38rfTGVP-orFpnH09Q4KMt8azG3GshoRCKdvKiBiMEdiBwLq-p40zMUvM7WYvs4_YZ6A5QrMdDJ-7NvjbQ_dqezYUVABllBFNmIBtSUAuxx45X0_I1v3WZk2G_gGSiHwL5"
    }

    try{
        return await axios.post('https://fcm.googleapis.com/fcm/send',{
            "to":"eRj6ZKW3xAsA5Eh_93ewdu:APA91bE4wfxKbjccxJyA5eF2ns6vVEcNynoukQVSw9NVgPyCBU_Sz18aZNjw12MSNSwAeXJUn7uXiWcnFAmP3WKvyo0cYZLbtOdJNJdMXESPE5U2Hw0t7-NnzBzR2iIRGqy9nqy60Q-Z",
            "notification": {
                "title":"hello",
                "body":"helloo",
                "sound": "default"
            }
           
    },{headers:headers}) .then(response => {
        console.log('response data----->>>', response);
        return response
    })
    }  catch (error) {
        console.log("error in usectr--" + error)
        return Promise.resolve(false)

    }
}
export async function getUserDetails() {
    var headers = {
        'Content-Type': 'application/json'
    }
    
    try {
        return await axios.get("https://localhost:44351/get",{ headers: headers })
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