import React, { Component } from 'react';
import { Card, InputBase, Dialog, Button, Chip, DialogTitle, DialogActions } from '@material-ui/core';
import AddAlertOutlinedIcon from '@material-ui/icons/AddAlertOutlined';
import PersonAddOutlinedIcon from '@material-ui/icons/PersonAddOutlined';
import ImageOutlinedIcon from '@material-ui/icons/ImageOutlined';
import ArchiveOutlinedIcon from '@material-ui/icons/ArchiveOutlined';
import MoreVertOutlinedIcon from '@material-ui/icons/MoreVertOutlined';
import DeleteIcon from '@material-ui/icons/Delete';
import ColorPalletComponent from './colorPalletComponent'
import { getAllNotes, deleteNotes, archiveNotes, updateNotes, unReminder, collabNotes,unPinNotes } from '../Controllers/notesController.js'
import RemainderComponent from './remainderComponent';
import ColloborartorComponent from './colloborartorComponent'
import unpin from '../Assests/unpin.svg'



export default class PinComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            notes: [],
            Title: "",
            Description: "",
            Id: "",
            Reminder: "",
            IsArchive: "",
            IsTrash: "",
            IsPin: "",
            Color: "",
            Image: "",
            Email: "",
            open: false,
            senderEmail: "",
            receiverEmail: "",
            collabId: "",
            pin:false

        }
    }
    componentDidMount() {
        this.getNotes()

    }

    getNotes = () => {
        getAllNotes(this.state.Email).then((response) => {
            console.log('response is after getting', response);
            this.setState({
                notes: response.data
            })
            console.log("list of notes is", this.state.notes);

        })
    }

    handleOpen = async () => {
        await this.setState({
            open: !this.state.open
        })
        console.log("dialog on click", this.state.open);

    }
    handleClose = () => {
        this.setState({
            open: false
        })
    }
    handleChangeTitle = async (event) => {
        const Title = await event.target.value
        this.setState({
            Title: Title
        })
        console.log("title after set state", this.state.Title)
    }
    handleChangeDescription = async (event) => {
        const Description = await event.target.value
        this.setState({
            Description: Description
        })
        console.log("Description after set state", this.state.Description)
    }
    handleChangeReminder = (event) => {
        const Remainder = event.target.value
        this.setState({
            Remainder: Remainder
        })
        console.log("Description after set state", this.state.Description)
    }
    handleDeleteNotes = (key) => {
        console.log("key of notes id", key);


        if (key === "") {
            this.setState({
                openSnackBar: true,
                snackBarMessage: "Id cannot be empty..!"
            });


        } else {
            var data = {
                Id: key

            }
            console.log("note id's", data.Id);
            deleteNotes(data)
                .then((response) => {
                    console.log("Delete response====>", response);
                    this.getNotes()

                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Deleted Successfully!!"
                    });
                    //this.props.props.history.push("/dashboard");

                })
                .catch((err) => {
                    console.log("error occured while deleting----------", err);
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Error occured while deleting!!"
                    });
                });
        }
    };
    handleArchiveNotes = (key) => {
        console.log("key of Archive notes id", key.Id);

        if (key === "") {
            this.setState({
                openSnackBar: true,
                snackBarMessage: "Id cannot be empty..!"
            });


        } else {
            var data = {
                Id: key


            }
            console.log("Archive id's", data.Id);
            archiveNotes(data)
                .then((response) => {
                    console.log("Archive Notes response====>", response);
                    this.getNotes()
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Get Successfully!!"
                    });
                    this.props.history.push("/dashboard");

                })
                .catch((err) => {
                    console.log("error occured while Getting----------", err);
                    this.setState({
                        openSnackBar: true,
                        snackBarMessage: "Error occured while Getting!!"
                    });
                });
        }
    };

    updateNote = (data) => {
        console.log("dialog data==> before sending to bcend", data);

        updateNotes(data)
            .then((response) => {
                console.log(" Notes response after updation====>", response);
                this.getNotes()

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
    handleUpdate = (Email, Id, oldTitle, oldDescription, Color) => {
        console.log("key of Update notes id", Id, Color);


        this.setState({
            open: !this.state.open,
            Id: Id,
            Title: oldTitle,
            Description: oldDescription,
            Color: Color,
            Email: Email
        })
        var data = {
            Id: this.state.Id,
            Title: this.state.Title,
            Description: this.state.Description,
            Color: this.state.Color,
            Email: this.state.Email
        }

        console.log("update id's", data.Email, data.Id, data.Color);
        this.updateNote(data)

    }
    handleColor = async (Color, Id, oldTitle, oldDescription) => {
        console.log("dialog color change==>  state3 check", Id, Color);

        await this.setState({
            Color: Color,
            Id: Id,
            Title: oldTitle,
            Description: oldDescription,



        })
        console.log("color after set State", this.state.Id, this.state.Title, this.state.Description, this.state.Color);

        var data = {

            Id: Id,
            Title: oldTitle,
            Description: oldDescription,
            Color: Color


        }
        console.log("color data before updation", data);

        this.updateNote(data)


    }

    handleReminder = (Reminder, Color, Id, oldTitle, oldDescription) => {
        console.log("key of Reminder notes id", Reminder, Color, Id, oldTitle, oldDescription);


        this.setState({

            Id: Id,
            Title: oldTitle,
            Description: oldDescription,
            Color: Color,
            Reminder: Reminder

        })
        var data = {
            Id: Id,
            Title: oldTitle,
            Description: oldDescription,
            Color: Color,
            Reminder: Reminder,
            Email: this.state.Email
        }

        console.log("REminder id's", data.Reminder, data.Id, data.Color, data.Title, data.Description);
        this.updateNote(data)

    }

    handleReminderDelete = async (Id) => {
        console.log("key of UnReminder notes id", Id);
        var data = {
            Id: Id
        }

        console.log("UnREminder id's", data.Id);
        await unReminder(data)
            .then((response) => {
                console.log("Archive Notes response====>", response);
                this.getNotes()
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
    handleCollab = (Id, Email, ReceiverEmail) => {
        console.log("key of Collab notes id", Id, Email, ReceiverEmail);


        this.setState({

            Id: Id,
            Email: Email,
            receiverEmail: ReceiverEmail

        })
        localStorage.setItem("receiver", this.state.receiverEmail);
        var data = {
            Id: Id,
            Email: this.state.Email,
            receiverEmail: ReceiverEmail
        }

        console.log("collab id's", data.Id, data.Email, data.receiverEmail);
        collabNotes(data)
            .then((response) => {
                console.log(" Notes response after updation====>", response);
                this.getNotes()

                //    await this.setState({
                //        collabId:response.data.result
                //     });
                console.log("collabId----------------", this.state.collabId);



            })
            .catch((err) => {
                console.log("error occured while Getting----------", err);
                this.setState({
                    openSnackBar: true,
                    snackBarMessage: "Error occured while Getting!!"
                });
            });
    }
    handleUnPin = async (key) => {
        var data = {
            Id: key
        }
        await unPinNotes(data)
            .then((response) => {
                console.log("data from frontend------>>>>", response);
                this.setState({
                    openSnackBar: true,
                    snackBarMessage: "added Successfully!!"
                });

            })
    }



    render() {
        const list = this.props.list ?  "listview" :null
        var datas = localStorage.getItem('myData');
        console.log(datas);
        this.state.Email = datas;

        var get = this.state.notes.map(key => {

            console.log("get" + get);

            return (

                (((key.IsPin===true))
                    &&
                    <div className='get-notes' id={list} >
                        <Card className='notes-card cardDesc' style={{ backgroundColor: key.Color }} key={key.Id}  id={list}  >
                            <div className='notes-align'>
                                <div className='notes-align-div'>
                                <div className='pin'>
                                    <b>
                                        <InputBase
                                            multiline
                                            placeholder="Title"
                                            id="Title"
                                            value={key.Title}
                                            onClick={() => this.handleUpdate(datas, key.Id, key.Title, key.Description, key.Color)}
                                        />
                                    </b>
                                    <img src={unpin} alt="unpin" onClick={() => this.handleUnPin(key.Id)} />
                                    </div>
                                    <InputBase
                                        multiline
                                        placeholder="Description"
                                        id="Description"
                                        value={key.Description}
                                        onClick={() => this.handleUpdate(datas, key.Id, key.Title, key.Description, key.Color)}
                                    />
                                    <div>
                                        {(key.Reminder !== null) ?
                                            <div className='chip-reminder'>
                                                <Chip
                                                    label={key.Reminder}
                                                    //value={key.Reminder}
                                                    onDelete={() => this.handleReminderDelete(key.Id)}
                                                    color="black"
                                                    variant="outlined"
                                                /></div> : <div className='empty-div'></div>}
                                    </div>
                                    {(key.Id === this.state.Id && this.state.collabId > 0) ?
                                        <div className='collab'>
                                            <Chip
                                                label={localStorage.getItem("receiver")}
                                                //value={key.receiverEmail}
                                                onDelete={() => this.handleCollaborator(key.Id, key.senderEmail, key.receiverEmail)}
                                                color="black"
                                                variant="outlined"
                                            /></div> : null}

                                </div>

                                <div className='created-notes-icon '>
                                    <RemainderComponent

                                        reminderProps={this.handleReminder}
                                        Color={key.Color}
                                        noteId={key.Id}
                                        Title={key.Title}
                                        Desc={key.Description}


                                    />
                                    <ColloborartorComponent collabProps={this.handleCollab}
                                        noteId={key.Id}
                                        senderEmail={this.state.Email} />
                                    <ColorPalletComponent
                                        colorProps={this.handleColor}
                                        noteId={key.Id}
                                        Title={key.Title}
                                        Desc={key.Description}
                                    />
                                    <ImageOutlinedIcon />
                                    <ArchiveOutlinedIcon onClick={() => this.handleArchiveNotes(key.Id)} />
                                    <DeleteIcon onClick={() => this.handleDeleteNotes(key.Id)} />
                                    <MoreVertOutlinedIcon />
                                </div>
                            </div>
                        </Card>


                        <Dialog open={this.state.open} onClose={this.handleClose}>
                            <Card className='notes-card' style={{ backgroundColor: this.state.Color }} >
                                <div className='notes-align'>
                                    <DialogTitle>
                                        <b>
                                            <InputBase
                                                multiline
                                                placeholder="Title"
                                                id="Title"
                                                value={this.state.Title}
                                                onChange={this.handleChangeTitle}
                                            /></b>
                                        <InputBase
                                            multiline
                                            placeholder="Description"
                                            id="Description"
                                            value={this.state.Description}
                                            onChange={this.handleChangeDescription}
                                        />
                                    </DialogTitle>
                                    <DialogActions>
                                        <div className='created-notes-icon1 '>
                                            <RemainderComponent reminderProps={() => this.handleReminder(key.Reminder, key.Color, key.Id, key.Title, key.Description)} />
                                            <ColloborartorComponent collabProps={() => this.handleCollaborator(key.Id, key.Email, key.receiverEmail)} />
                                            <ColorPalletComponent colorProps={this.handleColor}
                                                noteId={this.state.Id}
                                                Title={this.state.Title}
                                                Desc={this.state.Description}
                                            />
                                            <ImageOutlinedIcon />
                                            <ArchiveOutlinedIcon onClick={() => this.handleArchiveNotes(key.Id)} />
                                            <DeleteIcon onClick={() => this.handleDeleteNotes(key.Id)} />
                                            <MoreVertOutlinedIcon />
                                            <Button variant="contained" onClick={() => this.handleUpdate(datas, key.Id, key.Title, key.Description, key.Color)}>Close</Button>
                                        </div>
                                    </DialogActions>
                                </div>
                            </Card>

                        </Dialog>
                        {/**</ClickAwayListener>*/}
                    </div>


                )

            )

        })
        return (
            <div className='notes-list'>
                {get}
            </div>
        )
    }
}
