import React, { Component } from 'react'
import { Card, TextField, Paper, Popper, Button, Dialog } from '@material-ui/core'
import AddAlertOutlinedIcon from '@material-ui/icons/AddAlertOutlined';
import { withRouter } from 'react-router-dom';
import InputOutlinedIcon from '@material-ui/icons/InputOutlined';
import { MuiPickersUtilsProvider, TimePicker, DatePicker } from '@material-ui/pickers';
import DateFnsUtils from '@date-io/date-fns';
class RemainderComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            anchorEL: false,
            Reminder: "",
            selectedDate: new Date().toLocaleString,
            open: false
        }
    }
    handleReminder = (value) => {
        console.log("rem value", value);
        this.props.reminderProps(value, this.props.noteId, this.props.Title, this.props.Desc, this.props.Color,this.props.SenderEmail,this.props.ReceiverEmail,this.props.Label,this.props.Image)
    }

    handleToggle = (event) => {
        this.setState({
            //anchorEL: this.state.anchorEL ? false : event.target
            open:!this.state.open
        });
        console.log(event);

    }
    closePopper = () => {
        this.setState({
            open: false

        })
    }
    handleReminderChange = (value) => {
        console.log("rem value", value);

        const Reminder = value
        this.setState({
            Reminder: Reminder
        })
        console.log("remindrer------------>>>>>", this.state.Reminder);

    }
    handleClose=()=>{
        this.setState({
            
            open: false
        });
    }

    handleDateChange = date => {
        console.log("date event", date);
        this.setState({ 
            selectedDate: date 
            
        });
    };
    
    render() {
        // console.log("props of reminder", this.props);


        return (
            
            <div>
                <AddAlertOutlinedIcon onClick={this.handleToggle} />
                <Dialog open={this.state.open} onClose={this.handleClose}>

                    <Card style={{backgroundColor:"dimgrey" }}>
                        <div className='collab-card'>
                            <b >Reminder:</b>
                            <Button onClick={() => this.handleReminder(this.state.selectedDate)}>save</Button>
                        </div>
                        <MuiPickersUtilsProvider utils={DateFnsUtils}>
                            <DatePicker
                                margin="normal"
                                label="Date picker"
                                value={this.state.selectedDate}
                                onChange={this.handleDateChange}
                            />
                            <TimePicker
                                margin="normal"
                                label="Time picker"
                                value={this.state.selectedDate}
                                onChange={this.handleDateChange}
                            />
                        </MuiPickersUtilsProvider>
                        
                    </Card>

                </Dialog>

            </div>
        )
    }
}
export default withRouter(RemainderComponent)