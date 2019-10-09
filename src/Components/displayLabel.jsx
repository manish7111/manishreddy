import React, { Component } from 'react'
import { withRouter } from 'react-router-dom'
import { getLabelByLabel } from '../Controllers/labelController'
import { Card, InputBase, Dialog, Button, Chip, DialogTitle, DialogActions } from '@material-ui/core';
import AddAlertOutlinedIcon from '@material-ui/icons/AddAlertOutlined';
import PersonAddOutlinedIcon from '@material-ui/icons/PersonAddOutlined';
import ImageOutlinedIcon from '@material-ui/icons/ImageOutlined';
import ArchiveOutlinedIcon from '@material-ui/icons/ArchiveOutlined';
import MoreVertOutlinedIcon from '@material-ui/icons/MoreVertOutlined';
import DeleteIcon from '@material-ui/icons/Delete';
import ColorPalletComponent from './colorPalletComponent'
import { getAllNotes, deleteNotes, archiveNotes, updateNotes, unReminder, removeCollab, pinNotes, imageUpload } from '../Controllers/notesController.js'
import RemainderComponent from './remainderComponent';
import ColloborartorComponent from './colloborartorComponent'
import pin from '../Assests/pin.svg'
import MoreIconComponent from '../Components/moreIconComponent'
import { Alarm } from '@material-ui/icons'
import PersonSharpIcon from '@material-ui/icons/PersonSharp';
import ImageComponent from '../Components/imageComponent';


class DisplayLabel extends Component {
    constructor(props) {
        super(props)

        this.state = {
            notes: []
        }
    }
    componentDidMount() {
        const label = this.props.location.state
        getLabelByLabel(label).then((response) => {
            console.log('response is after getting', response);
            this.setState({
                notes: response.data.result
            })
            console.log("list of label notes is", this.state.notes);
        })
    }
    handleDeleteNotes = (key) => {
        console.log("key of notes id", key);
            var data = {
                Id: key
            }
            console.log("note id's", data.Id);
            deleteNotes(data)
                .then((response) => {
                    console.log("Delete response====>", response);
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
        const list = this.props.list ? "listview" : null
        const get = this.state.notes.map(key => {
            return(
                <div className='label-notes' id={list}>
                    <Card className='notes-card cardDesc' style={{ backgroundColor: key.Color }} id={list}  >
                        <div className='notes-align'>
                            {(key.Image != null) ?
                                <div className='image-upload'>
                                    <img src={key.Image} style={{ height: "25%", width: "27.15%" }} />
                                </div> : (null)}
                            <div className='notes-align-div'>
                                <div className='pin'>
                                    <b>
                                        <InputBase
                                            className="title"
                                            multiline
                                            placeholder="Title"
                                            id="Title"
                                            value={key.Title}
                                            onClick={() => this.handleUpdate(key.Id, key.Title, key.Description, key.Color, key.Reminder, key.SenderEmail, key.ReceiverEmail, key.Label)}
                                        />
                                    </b>
                                    <img src={pin} alt="pin" onClick={() => this.handlePin(key.Id)} />
                                </div>
                                <InputBase
                                    multiline
                                    className="title"
                                    placeholder="Description"
                                    id="Description"
                                    value={key.Description}
                                    onClick={() => this.handleUpdate(key.Id, key.Title, key.Description, key.Color, key.Reminder, key.SenderEmail, key.ReceiverEmail, key.Label)}
                                />
                            </div>

                            <div>
                                {(key.Reminder !== null) ?
                                    <div className='chip-reminder'>
                                        <Chip
                                            icon={<Alarm />}
                                            label={key.Reminder}
                                            onDelete={() => this.handleReminderDelete(key.Id)}
                                            color="black"
                                            variant="outlined"
                                        /></div> : <div className='empty-div'></div>}
                            </div>
                            {(key.SenderEmail === this.state.Email) ?
                                (key.ReceiverEmail !== null) ?
                                    <div className='collab'>
                                        <Chip
                                            icon={<PersonSharpIcon />}
                                            label={key.ReceiverEmail}
                                            onDelete={() => this.handleCollaboratorDelete(key.Id)}
                                            color="black"
                                            variant="outlined"
                                        /></div> : <div className='empty-div'></div>
                                :
                                (key.SenderEmail !== null) ?
                                    <div className='collab'>
                                        <Chip
                                            icon={<PersonSharpIcon />}
                                            label={key.SenderEmail}
                                            onDelete={() => this.handleCollaboratorDelete(key.Id)}
                                            color="black"
                                            variant="outlined"
                                        /></div> : <div className='empty-div'>
                                    </div>}

                            {(key.Label !== null) ?
                                <div className='label-chip'>
                                    <Chip
                                        label={key.Label}
                                        onDelete={() => this.handleDeleteLabel(key.Id)}
                                        color="black"
                                        variant="outlined"
                                    /></div> : <div className='empty-div'></div>}

                            <div className='created-notes-icon '>
                                <RemainderComponent

                                    reminderProps={this.handleReminder}
                                    noteId={key.Id}
                                    Title={key.Title}
                                    Desc={key.Description}
                                    Color={key.Color}
                                    SenderEmail={key.SenderEmail}
                                    ReceiverEmail={key.ReceiverEmail}
                                    Label={key.Label}
                                    Image={key.Image}
                                />
                                <ColloborartorComponent collabProps={this.handleCollab}
                                    noteId={key.Id}
                                    Title={key.Title}
                                    Desc={key.Description}
                                    Color={key.Color}
                                    Reminder={key.Reminder}
                                    SenderEmail={key.SenderEmail}
                                    ReceiverEmail={key.ReceiverEmail}
                                    Label={key.Label}
                                    Image={key.Image}
                                />
                                <ColorPalletComponent
                                    colorProps={this.handleColor}
                                    noteId={key.Id}
                                    Title={key.Title}
                                    Desc={key.Description}
                                    Reminder={key.Reminder}
                                    SenderEmail={key.SenderEmail}
                                    ReceiverEmail={key.ReceiverEmail}
                                    Label={key.Label}
                                    Image={key.Image}
                                />
                                {/*<ImageOutlinedIcon/>*/}
                                <ImageComponent
                                    imageProps={this.handleImage}
                                    noteId={key.Id}

                                ></ImageComponent>
                                <ArchiveOutlinedIcon onClick={() => this.handleArchiveNotes(key.Id)} />
                                <DeleteIcon onClick={() => this.handleDeleteNotes(key.Id)} />
                                <MoreIconComponent
                                    moreToGetNotesProps={this.handleLabelUpdate}
                                    noteId={key.Id}
                                    Title={key.Title}
                                    Desc={key.Description}
                                    Color={key.Color}
                                    Reminder={key.Reminder}
                                    SenderEmail={this.state.Email}
                                    ReceiverEmail={key.ReceiverEmail}


                                />

                            </div>
                        </div>
                    </Card>
                </div>
            )
        }
        )
        return (
            <div className='labels-list'>
                {get}
            </div>
        )
    }
}
    export default withRouter(DisplayLabel)
