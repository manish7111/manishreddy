/*****************************************************************************************************
 *  @Purpose        : Here we have to create the userServices that contains all required userServices functions.
 *  @file           : userServices.jsx       
 *  @author         : Manish Reddy
 *  @version        : v0.1
 *  @since          : 12-09-2019
 *****************************************************************************************************/
import firebase from 'firebase';
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
    console.log("new user", newUser.Email);

    var params = {
        Email: newUser.Email
    }
    try {
        return axios.post("https://localhost:44351/fblogin", newUser, { params: params })
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

export const askForPermissioToReceiveNotifications = async (userdate, Title, Description) => {
    try {
        console.log("userdateuserdateuserdate==>", userdate,Title,Description);
        const messaging = firebase.messaging();
        await messaging.requestPermission();
        const token = await messaging.getToken();
        console.log('token:============>', token);
        var date = new Date()
        console.log("date-->0", date);
        var date1 = new Date(userdate)
        console.log("date1111-->0", date1);
        var diff = Math.abs(date1 - date);
        console.log("diff----->", diff);

        setTimeout( () => {
            var data = {
                "notification": {
                    "title": Title,
                    "body": Description,
                    "sound": "default"
                    // "click_action": "http://localhost:3000/",
                    // "icon": "http://url-to-an-icon/icon.png"
                },
                "to": token
                // "to": process.env.token
            }
         passmessage(data);
        }, diff);
       return diff;
        
    } catch (error) {
        console.error("errorrrrrrrrrrrrrrrrrr", error);
    }
}

function passmessage(data) {
    console.log("hiii");
    
    try {
        axios.post('https://fcm.googleapis.com/fcm/send', data, { headers: { 'Authorization': 'key=AAAABWNyTkE:APA91bEgAw38rfTGVP-orFpnH09Q4KMt8azG3GshoRCKdvKiBiMEdiBwLq-p40zMUvM7WYvs4_YZ6A5QrMdDJ-7NvjbQ_dqezYUVABllBFNmIBtSUAuxx45X0_I1v3WZk2G_gGSiHwL5','Content-Type':'application/json' } })
            .then((res) => {
                //return res;
                console.log("res----->", res);
            })
            .catch((err) => {
                console.log("errors==>", err);
            })
    } catch (error) {
        console.log("Error in resetpassword in userservices..");
    }
}










