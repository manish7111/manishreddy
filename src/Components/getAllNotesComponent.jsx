import React, { Component } from 'react';
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

function Search(searchValue) {
    return function (value) {
        return value.Title.includes(searchValue) || value.Description.includes(searchValue)
    }
}
export default class GetAllNotesComponent extends Component {
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
            ReceiverEmail: "",
            collabId: "",
            SenderEmail: "",
            Label: ""

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
    handleUpdate = async (noteId, Title, Desc, Color, value, SenderEmail, ReceiverEmail, Label,Image) => {
        console.log("key of Update notes id", noteId, Title, Desc, value, Color, ReceiverEmail, SenderEmail, Label,Image);
        this.setState({
            open: !this.state.open,
            Id: noteId,
            Title: Title,
            Description: Desc,
            Reminder: value,
            Color: Color,
            ReceiverEmail: ReceiverEmail,
            SenderEmail: this.state.Email,
            Label: Label,
            Image: Image
        })
        var data = {
            Id: this.state.Id,
            Email: this.state.Email,
            Title: this.state.Title,
            Description: this.state.Description,
            Reminder: this.state.Reminder,
            Color: this.state.Color,
            ReceiverEmail: this.state.ReceiverEmail,
            SenderEmail: this.state.SenderEmail,
            Label: this.state.Label,
            Image:this.state.Image
        }

        console.log("update id's", data.Email, data.Id, data.Color);
        await this.updateNote(data)
    }

    handleColor = async (Color, noteId, Title, Desc, value, SenderEmail, ReceiverEmail, Label,Image) => {
        console.log("dialog color change==>  state3 check", noteId, Title, Desc, value, Color, ReceiverEmail, SenderEmail, Label,Image);
        this.setState({
            Color: Color,
        })
        console.log("color after set State", this.state.Id, this.state.Title, this.state.Description, this.state.Color);
        var data = {

            Id: noteId,
            Email: this.state.Email,
            Title: Title,
            Description: Desc,
            Reminder: value,
            Color: Color,
            ReceiverEmail: ReceiverEmail,
            SenderEmail: SenderEmail,
            Label: Label,
            Image:Image
        }
        console.log("color data before updation", data);
        await this.updateNote(data)
    }

    handleReminder = (value, noteId, Title, Desc, Color, SenderEmail, ReceiverEmail, Label,Image) => {
        console.log("key of Reminder notes id", noteId, Title, Desc, value, Color, ReceiverEmail, SenderEmail, Label,Image);


        this.setState({
            Reminder: value
        })
        var data = {
            Id: noteId,
            Email: this.state.Email,
            Title: Title,
            Description: Desc,
            Reminder: value,
            Color: Color,
            ReceiverEmail: ReceiverEmail,
            SenderEmail: SenderEmail,
            Label: Label,
            Image:Image

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
    handleCollab = (ReceiverEmail, noteId, Title, Desc, Color, value, SenderEmail, Label,Image) => {
        console.log("key of Collab notes id 1,2,3,4,5,6,", noteId, Title, Desc, value, Color, ReceiverEmail, SenderEmail, Label,Image);


        this.setState({
            ReceiverEmail: ReceiverEmail
        })

        var data = {
            Id: noteId,
            Email: this.state.Email,
            Title: Title,
            Description: Desc,
            Reminder: value,
            Color: Color,
            ReceiverEmail: ReceiverEmail,
            SenderEmail: this.state.Email,
            Label: Label,
            Image:Image
        }
        console.log("data ---------------##!@@##$@$", data.Id, data.Email, data.ReceiverEmail, data.Title, data.Description, data.Color, data.SenderEmail);

        this.updateNote(data);

    }
    handlePin = async (key) => {
        var data = {
            Id: key
        }
        await pinNotes(data)
            .then((response) => {
                console.log("data from frontend------>>>>", response);
                this.setState({
                    openSnackBar: true,
                    snackBarMessage: "added Successfully!!"
                });

            })
    }
    handleCollaboratorDelete = async (Id) => {
        console.log("key of collab remove notes id", Id);
        var data = {
            Id: Id
        }

        console.log("Collab delete id", data.Id);
        await removeCollab(data)
            .then((response) => {
                console.log("remove collab to Notes response====>", response);
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

    handleLabelUpdate = async (noteId, Title, Desc, value, Color, ReceiverEmail, SenderEmail, Label) => {
        console.log("value of noteId in get notes", noteId);
        console.log("value of Title in get notes", Title);

        console.log("value of Desc in get notes", Desc);

        console.log("value of value in get notes", value);
        console.log("value of Color in get notes", Color);
        console.log("value of ReceiverEmail in get notes", ReceiverEmail);
        console.log("value of SenderEmail in get notes", SenderEmail);
        console.log("value of label in get notes", Label);
        console.log("value of mail in get notes", this.state.Email);

        this.setState({
            Label: Label

        })

        var data = {
            Id: noteId,
            Email: this.state.Email,
            Title: Title,
            Description: Desc,
            Reminder: value,
            Color: Color,
            ReceiverEmail: ReceiverEmail,
            SenderEmail: SenderEmail,
            Label: Label

        }
        console.log("Label in get notes ------------->", data);
        await this.updateNote(data);

    }
    handleImage = async (Image, noteId) => {
        console.log("image in dash", Image, noteId);
        let image = Image;

        this.setState(prevState => ({
            Image: URL.createObjectURL(Image),
            Id: noteId
        }))

        let formData = new FormData();

        formData.append('image', Image);
        formData.append('Id', noteId)
        console.log("forma data  ", formData);
        await imageUpload(formData, noteId).then((response) => {
            console.log("response data in uploading pic ", response)
           
        })
    }

    render() {
        console.log("props from more icon is ------", this.props.moreToGetNotesProps);

        const list = this.props.list ? "listview" : null
        var datas = localStorage.getItem('myData');
        console.log(datas);
        this.state.Email = datas;

        var get = this.state.notes.filter(Search(this.props.searchProps)).map(key => {

            console.log("get" + get);

            return (

                (((key.IsArchive === false)
                    && (key.IsTrash === false) && (key.IsPin === false))
                    &&
                    <div className='get-notes' id={list}>
                        <Card className='notes-card cardDesc' style={{ backgroundColor: key.Color }} id={list}  >
                            <div className='notes-align'>
                            {(key.Image != null) ?
                                <div className='image-upload'>
                                    <img src={key.Image} style={{height:"25%",width:"27.15%"}}/>
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
                                        <Chip
                                            icon={<Alarm />}
                                            label={key.Reminder}
                                        />
                                        <Chip
                                            icon={<PersonSharpIcon />}
                                            label={key.ReceiverEmail}
                                        />
                                    </DialogTitle>
                                    <DialogActions>
                                        <div className='created-notes-icon1 '>
                                            <RemainderComponent reminderProps={() => this.handleReminder(key.Reminder, key.Color, key.Id, key.Title, key.Description, key.Email, key.SenderEmail, key.ReceiverEmail, key.Label)} />
                                            <ColloborartorComponent collabProps={() => this.handleCollaborator(key.Id, key.Email, key.receiverEmail)} />
                                            <ColorPalletComponent colorProps={this.handleColor}
                                                noteId={this.state.Id}
                                                Title={this.state.Title}
                                                Desc={this.state.Description}
                                                Reminder={this.state.Reminder}
                                                SenderEmail={this.state.SenderEmail}
                                                ReceiverEmail={this.state.ReceiverEmail}
                                                Label={key.Label}
                                                Image={key.Image}
                                            />
                                            <ImageOutlinedIcon />
                                            <ArchiveOutlinedIcon onClick={() => this.handleArchiveNotes(key.Id)} />
                                            <DeleteIcon onClick={() => this.handleDeleteNotes(key.Id)} />
                                            <MoreIconComponent
                                                moreToGetNotesProps={this.handleLabelUpdate}
                                                Color={key.Color}
                                                noteId={key.Id}
                                                Title={key.Title}
                                                Desc={key.Description}
                                                Reminder={key.Reminder}
                                                SenderEmail={key.SenderEmail}
                                                ReceiverEmail={key.ReceiverEmail}
                                                Email={this.state.Email}

                                            />
                                            <Button variant="contained" onClick={() => this.handleUpdate(key.Id, key.Title, key.Description, key.Color, key.Reminder, key.SenderEmail, key.ReceiverEmail, key.Label,key.Image)}>Close</Button>
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
