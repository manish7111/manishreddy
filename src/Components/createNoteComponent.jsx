import React, { Component } from 'react';
import InputBase from '@material-ui/core/InputBase';
import { Card, Button } from '@material-ui/core';
import { withRouter } from 'react-router-dom';
import AddAlertOutlinedIcon from '@material-ui/icons/AddAlertOutlined';
import PersonAddOutlinedIcon from '@material-ui/icons/PersonAddOutlined';
import ColorLensOutlinedIcon from '@material-ui/icons/ColorLensOutlined';
import ImageOutlinedIcon from '@material-ui/icons/ImageOutlined';
import ArchiveOutlinedIcon from '@material-ui/icons/ArchiveOutlined';
import MoreVertOutlinedIcon from '@material-ui/icons/MoreVertOutlined';
import ColorPalletComponent from '../Components/colorPalletComponent'
import { addNotes, getAllNotes } from '../Controllers/notesController.js'

class CreateNoteComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            openCard: true,
            Title: "",
            Description: "",
            Color: "",
            newNote:[]

        }

    }
    handleChangeTitle = (event) => {
        const Title = event.target.value
        this.setState({
            Title: Title
        })
    }
    handleChangeDescription = (event) => {
        const Description = event.target.value
        this.setState({
            Description: Description
        })
    }
    handleNoteClick = () => {

        this.setState({
            openCard: !this.state.openCard
        })

    }
    handleNoteAddClick=(event)=>{
        console.log("in handle click");

        event.preventDefault();
        if (this.state.Title === "" && this.state.Description === "") {
            console.log("in if" + this.state.Title + "" + this.state.Description);

            this.setState({
                openSnackBar: true,
                snackBarMessage: "Title cannot be empty..!"
            });

        }
        else {
            var data = {
                Title: this.state.Title,
                Description: this.state.Description,
                Color: this.state.Color,
                Email:this.state.Email
            }
            console.log("title " + this.state.Email);

            
            addNotes(data)
                .then((response) => {
                    console.log("add response====>", response);
                    this.setState({
                        newNote:response.config.data
                    })
                    console.log("response after setstate",this.state.newNote);
                    // this.props.history.push("/dashboard");
                    this.props.createNoteProps(this.state.newNote);
            })
            
                .catch((err) => {
                    console.log("error in adding notes----------", err);
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "notes add Unsuccessful!!"
                    });
                });
                
        }
    };
    handleColor =async (value) => {
        console.log("color value is",value);
      await  this.setState({
            Color: value
        })
        
        console.log("color is",this.state.Color);
        


    }

    render() {
        var datas =localStorage.getItem('myData');
        console.log(datas);
        this.state.Email=datas;
        return (
            <div className='create-note-class'>
                {!this.state.openCard ?
                    <div className='Create-Note-Title'>
                        <Card style={{backgroundColor:this.state.Color}}>
                            <InputBase
                                placeholder="Title"
                                inputnoteprops={{ 'aria-label': 'Title' }}
                                onChange={this.handleChangeTitle}
                                value={this.state.Title}
                            />

                            <InputBase
                                placeholder="Description"
                                inputnoteprops={{ 'aria-label': 'Description' }}
                                onChange={this.handleChangeDescription}
                                value={this.state.Description}
                            />
                            <div className='Notes-Icon'>
                                <AddAlertOutlinedIcon />
                                <PersonAddOutlinedIcon />
                                <ColorPalletComponent   colorProps={this.handleColor}
                                noteId={""}
                                Title={""}
                                Desc={""}
                                />
                                <ImageOutlinedIcon />
                                <ArchiveOutlinedIcon />
                                <MoreVertOutlinedIcon />
                                <Button onClick={(event) => { this.handleNoteAddClick(event) }}>Close</Button>
                            </div>
                        </Card>
                    </div>

                    :
                    <div className='Create-Note' >
                        <Card onClick={() => this.handleNoteClick()} className="createNoteMainCard">
                            <InputBase
                                placeholder="Take a Note"
                                inputProps={{ 'aria-label': 'Take a Note' }}
                            />
                        </Card>
                    </div>

                }
            </div>
        )
    }
}
export default withRouter(CreateNoteComponent)