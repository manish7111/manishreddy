import React, { Component } from 'react'
import { withRouter } from 'react-router-dom'
import { Popper, Paper } from '@material-ui/core'
import MoreVertOutlinedIcon from '@material-ui/icons/MoreVertOutlined'
import CreateLabelComponent from '../Components/createLabelComponent'
import LabelOutlinedIcon from '@material-ui/icons/LabelOutlined'
class MoreIconComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            open: false,
            anchorEL: false,
            Label:""
        }
    }

    handleToggle = (event) => {
        console.log("event icon---->>>>>", event);

        this.setState({
            anchorEL: this.state.anchorEL ? false : event.target

        });
    }
    handleClose = () => {
        this.setState({
            open: false
        });
    }
    handleGetLabel =  (Label, noteId, Title, Desc,Color,value ,SenderEmail,ReceiverEmail) => {
console.log("label and value are",Label,value,Color,noteId,Title,Desc,SenderEmail,ReceiverEmail);
var data = {
    Id: noteId,
    Email:this.state.Email,
    Title: Title,
    Description: Desc,
    Reminder: value,
    Color:Color,
    ReceiverEmail:ReceiverEmail,
    SenderEmail: SenderEmail,
    Label:Label

}
console.log("Label in more ------------->", data);
        this.props.moreToGetNotesProps(noteId,Title,Desc,value,Color,ReceiverEmail,SenderEmail,Label)
    }



    render() {
        //console.log("MOC==>","noteId",this.props.noteId,"title",this.props.Title,"D",this.props.Desc,"C",this.props.Color,"R",this.props.Reminder,"SE",this.props.SenderEmail,"RE",this.props.ReceiverEmail);
        
        return (
            <div>
                <MoreVertOutlinedIcon onClick={this.handleToggle}  />
                <div className='more-icon'>
                    <Popper open={this.state.anchorEL} anchorEl={this.state.anchorEL} style={{ zIndex: "9999" }}>
                        <Paper style={{ zIndex: "9999", width: "140%" }}>
                            <div className='more-icon-div' >
                                <CreateLabelComponent
                                    labelProps={this.handleGetLabel}
                                    //sendDataProps={this.props.Color,this.props.noteId,this.props.Title,this.props.Desc,this.props.SenderEmail,this.props.ReceiverEmail,this.props.Reminder}
                                    noteId={this.props.noteId}
                                    Title={this.props.Title}
                                    Desc={this.props.Desc}
                                    Color={this.props.Color}
                                    Reminder={this.props.Reminder}
                                    SenderEmail={this.props.SenderEmail}
                                    ReceiverEmail={this.props.ReceiverEmail}
                                />

                            </div>
                        </Paper>
                    </Popper>
                </div>
            </div>
        )
    }
}
export default withRouter(MoreIconComponent)
