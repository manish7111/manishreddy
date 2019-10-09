import React, { Component } from 'react'
import { withRouter } from 'react-router-dom'
import PersonAddOutlinedIcon from '@material-ui/icons/PersonAddOutlined';
import { Paper, Popper, TextField, Avatar, Button, Dialog, Card, Divider, InputBase } from '@material-ui/core';


class ColloborartorComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            anchorEL: false,
            ReceiverEmail: "",
            Email: "",
            open: false

        }
    }
    handleToggle = (event) => {
        this.setState({
            // anchorEL: this.state.anchorEL ? false : event.target
            open: !this.state.open
        });
        console.log("collaborator event log------------>", event);
    }
    handleEmailChange = (event) => {
        console.log("....collab.....", event);

        const ReceiverEmail = event.target.value
        this.setState({
            ReceiverEmail: ReceiverEmail
        })
    }
    handleSave = async() => {
        console.log("collaborator value----->", this.state.ReceiverEmail);
        console.log("collab props----------->>>>>",this.props.Reminder);
      
      await  this.props.collabProps(this.state.ReceiverEmail, this.props.noteId,this.props.Title,this.props.Desc,this.props.Color,this.props.Reminder,this.props.SenderEmail,this.props.Label,this.props.Image)
    }
    handleClose=()=>{
        this.setState({
            
            open: false
        });
    }

    render() {
        var datas = localStorage.getItem('myData');
        this.state.Email = datas;
        return (
            <div>
                <PersonAddOutlinedIcon onClick={this.handleToggle} />
                <Dialog open={this.state.open} onClose={this.handleClose}>
                    <Card style={{backgroundColor:"dimgrey"}}>
                        <div className='collab-card'><b>Collaborators</b><Button onClick={() => this.handleSave()}>Send</Button></div>
                        <Divider />
                        <div className='collab-alaign'>
                            <InputBase
                                placeholder="Enter Personal or Email"
                                value={this.state.Email}
                            />
                            <InputBase
                                placeholder="(Owner)"
                            />
                        </div>
                        <div>
                            <InputBase
                                placeholder="Enter Personal or Email"
                                value={this.state.ReceiverEmail}
                                onChange={this.handleEmailChange}
                            />
                        </div>

                    </Card>
                </Dialog>
            </div>
        )
    }
}
export default withRouter(ColloborartorComponent)
