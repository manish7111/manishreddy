import React, { Component } from 'react';
import { Card, InputBase } from '@material-ui/core';
import AddAlertOutlinedIcon from '@material-ui/icons/AddAlertOutlined';
import PersonAddOutlinedIcon from '@material-ui/icons/PersonAddOutlined';
import ColorLensOutlinedIcon from '@material-ui/icons/ColorLensOutlined';
import ImageOutlinedIcon from '@material-ui/icons/ImageOutlined';
import ArchiveOutlinedIcon from '@material-ui/icons/ArchiveOutlined';
import MoreVertOutlinedIcon from '@material-ui/icons/MoreVertOutlined';
import DeleteIcon from '@material-ui/icons/Delete';
import { withRouter } from "react-router-dom";
import { getAllNotes,unArchiveNotes} from '../Controllers/notesController.js'

class ArchiveComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            notes: [],
            Title: "",
            Description: "",
            Id: "",
            Remainder: "",
            IsArchive: "",
            IsTrash: "",
            IsPin: "",
            Color: "",
            Image: "",
            Email: "",
            open: false
        }
    }
    componentDidMount() {
        this.getArchiveNotes()
    }
    getArchiveNotes=()=>{
        getAllNotes(this.state.Email).then((response)=>{
            console.log('response is after getting', response);
            this.setState({
                notes: response.data
            })
            console.log("list of Archived notes is", this.state.notes);
        })
    }
    

    handleOpen = () => {
        this.setState({
            open: true
        })
    }
    
    handleUnArchive=(key)=>{
        console.log("key of Archive notes id", key.Id);

            var data = {
                Id: key

            }
            console.log("Archive id's", data.Id);
            unArchiveNotes(data)
                .then((response) => {
                    console.log("UnArchive Notes response====>", response);
                    this.getArchiveNotes()
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Get Successfully!!"
                    });
                   
                })
                .catch((err) => {
                    console.log("error occured while Getting----------", err);
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Error occured while Getting!!"
                    });
                });
        
    }
    render() {
        var data=localStorage.getItem('myData');
        console.log("data in Archive",data);
        
        this.state.Email=data;
        var get = this.state.notes.map(key => {
            // console.log('keyId ', key);

            return (

                (((key.IsArchive === true)
                && (key.IsTrash === false))
                &&
                <div className='get-trash-notes'>
                    <Card className='notes-trash-card cardDesc' style={{backgroundColor:key.Color}} key={key.Id}>
                        <div className='notes-trash-align'>
                            <b>
                                <InputBase
                                    multiline
                                    placeholder="Title"
                                    id="Title"
                                    value={key.Title}
                                /></b>
                            <InputBase
                                multiline
                                placeholder="Description"
                                id="Description"
                                value={key.Description}
                            />
                            <div className='created-notes-icon' >
                                <AddAlertOutlinedIcon />
                                <PersonAddOutlinedIcon />
                                <ColorLensOutlinedIcon />
                                <ImageOutlinedIcon />
                                <ArchiveOutlinedIcon onClick={() => this.handleUnArchive(key.Id)}/>
                                <DeleteIcon  />
                                <MoreVertOutlinedIcon />
                            </div>
                        </div>
                    </Card>

                </div>

            )
            )

        })
        return (
            <div className='notes-trash-list'>
                {get}
            </div>
        )
    }
}
export default withRouter(ArchiveComponent)