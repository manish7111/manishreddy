const axios = require('axios');
export function addNotes(newUser) {
    console.log("new user",newUser.Title);
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.post("https://localhost:44351/add", newUser, { headers: headers })
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
export function getAllNotes(newUser) {
    console.log("-------------::::::::",newUser);
    
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        Email:newUser
    }
    try {
        return axios.get("https://localhost:44351/getnotess",{ params: params },{ headers: headers })
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
export function updateNotes(newUser) {
    console.log("new user",newUser.Id);
    var headers = {
        'Content-Type': 'application/json'
    }
    try {
        return axios.put("https://localhost:44351/update", newUser, { headers: headers })
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
export function deleteNotes(newUser) {
    console.log("new user",newUser.Id);
    var headers = {
        'Content-Type': 'application/json'
    }
    var params = {
        Id:newUser.Id
    }
    try {
        return axios.delete("https://localhost:44351/deletenotes", { params: params },{ headers: headers })
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
export function bulkTrash() {
    try {
        return axios.get("https://localhost:44351/trash")
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
export function archiveNotes(newUser) {
    console.log("new user",newUser);
    var params = {
        Id:newUser.Id
    }
    
 console.log(params);
 
    try {
        return axios.put("https://localhost:44351/isarchive",newUser,{params: params })
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
export function RemoveTrash() {
    try {
        return axios.get("https://localhost:44351/deleteTrash")
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
export function RestoreTrash() {
    try {
        return axios.get("https://localhost:44351/restoreTrash")
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
export function unArchiveNotes(newUser) {
    console.log("new user",newUser);
    var params = {
        Id:newUser.Id
    }
    
 console.log(params);
 
    try {
        return axios.put("https://localhost:44351/unarchive",newUser,{params: params })
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
export function deleteSingleNotes(newUser) {
    console.log("new user",newUser);
    var headers = {
        'Content-Type': 'application/json'
    }
    var params = {
        Id:newUser.Id
    }
    try {
        return axios.delete("https://localhost:44351/deleteTrashNotes", { params: params },{ headers: headers })
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
export function unReminder(newUser) {
    console.log("new user",newUser.Id);
    var headers = {
        'Content-Type': 'application/json'
    }
    var params = {
        Id:newUser.Id
       
    }
    console.log("--------------->....",params);
    try {
        return axios.delete(`${process.env.REACT_APP_BASE_URL}/unreminder`,{ params: params }, { headers: headers })
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
export function collabNotes(newUser) {
    console.log("new user",newUser.Id,newUser.ReceiverEmail);
    var headers = {
        'Content-Type': 'application/json'
    }
    var params = {
        Id:newUser.Id,
        ReceiverEmail:newUser.ReceiverEmail
    }
    try {
        return axios.post("https://localhost:44351/collaborator", { params: params }, { headers: headers })
            .then(response => {
                console.log('response data collab----->>>', response);
                return response
            })

    }
    catch (error) {
        console.log("error in usectr--" + error)
        return Promise.resolve(false)

    }
}

export function pinNotes(newUser) {
    console.log("new user",newUser.Id);
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        Id:newUser.Id
    }
    console.log(";;;;;;;;;",params);
    
    try {
        return axios.get(`${process.env.REACT_APP_BASE_URL}/pinnote`,{ params: params }, { headers: headers })
            .then(response => {
                console.log('response data collab----->>>', response);
                return response
            })

    }
    catch (error) {
        console.log("error in usectr--" + error)
        return Promise.resolve(false)

    }
}
export function unPinNotes(newUser) {
    console.log("new user",newUser.Id);
    var headers = {
        'Content-Type': 'application/json'
    }
    var params={
        Id:newUser.Id
    }
    try {
        return axios.get(`${process.env.REACT_APP_BASE_URL}/unpinnote`, { params: params }, { headers: headers })
            .then(response => {
                console.log('response data collab----->>>', response);
                return response
            })

    }
    catch (error) {
        console.log("error in usectr--" + error)
        return Promise.resolve(false)

    }
}
export function removeCollab(newUser) {
    console.log("new user",newUser.Id);
    var headers = {
        'Content-Type': 'application/json'
    }
    var params = {
        Id:newUser.Id
       
    }
    console.log("--------------->....",params);
    try {
        return axios.delete(`${process.env.REACT_APP_BASE_URL}/removecollaborator`,{ params: params }, { headers: headers })
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
export function search(newUser) {
    console.log("new user",newUser.Title);
    var headers = {
        'Content-Type': 'application/json'
    }
    var params = {
        Title:newUser.Title
       
    }
    console.log("--------------->....",params);
    try {
        return axios.get(`${process.env.REACT_APP_BASE_URL}/api/search`,{ params: params }, { headers: headers })
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
export  async function imageUpload(data,id) {
    console.log("data of profile upload",data )
    var headers = {
        "Content-Type": "multipart/formdata"
    }  
    var params = {
        Id:id
    }
    try {
        return await axios.post('https://localhost:44351/image', data, {params:params},{ headers: headers })
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
