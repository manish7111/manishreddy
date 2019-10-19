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
import { getAllNotes,deleteSingleNotes} from '../Controllers/notesController.js'

class TrashComponent extends Component {
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
        this.getTrashNotes()
    }
    getTrashNotes=()=>{
        getAllNotes(this.state.Email).then((response)=>{
            console.log('response is after getting', response);
            this.setState({
                notes: response.data
            })
            console.log("list of trash notes is", this.state.notes);
        })
    }
    

    handleOpen = () => {
        this.setState({
            open: true
        })
    }
    handleDeleteNotes = (key) => {
        console.log("key of delete notes is", key);

       
            var data = {
                Id: key

            }
            console.log("delete id's", data.Id);
            deleteSingleNotes(data)
                .then((response) => {
                    console.log("Delete response====>", response);
                    this.getNotes()

                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Deleted Successfully!!"
                    });
                   

                })
                .catch((err) => {
                    console.log("error occured while deleting----------", err);
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Error occured while deleting!!"
                    });
                });
        
    };
    
    render() {
        var data=localStorage.getItem('myData');
        console.log("data in trash",data);
        
        this.state.Email=data;
        var get = this.state.notes.map(key => {
            console.log(".........",key.Email);
            

            return (

                (((key.IsArchive === false)
                && (key.IsTrash === true))
                &&
                <div className='get-trash-notes' >
                    <Card className='notes-trash-card cardDesc1' style={{backgroundColor:key.Color}} key={key.Id}>
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
                            <div className='created-notes-icons' >
                                <AddAlertOutlinedIcon />
                                <PersonAddOutlinedIcon />
                                <ColorLensOutlinedIcon />
                                <ImageOutlinedIcon />
                                <ArchiveOutlinedIcon />
                                <DeleteIcon onClick={()=>this.handleDeleteNotes(key.Id)} />
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
export default withRouter(TrashComponent)