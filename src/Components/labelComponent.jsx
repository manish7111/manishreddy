import React, { Component } from 'react';
import { withRouter } from 'react-router-dom';
import LabelOutlinedIcon from '@material-ui/icons/LabelOutlined';
import { getLabel,getLabelByLabel } from '../Controllers/labelController'
import { MenuItem } from '@material-ui/core';

class LabelComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            notes: [],
            Email: "",
            Id: "",
            open: false,
            Label: ""
        }
    }
    componentDidMount() {
        this.getLabels()
    }
    getLabels = () => {
        getLabel(this.state.Email).then((response) => {
            console.log('response is after getting', response);
            this.setState({
                notes: response.data.result
            })
            console.log("list of label notes is", this.state.notes);
        })
    }
    handleClick = (key) => {
        console.log("key is ----->>>>>>//////", key);
        this.props.labelProps(key);
       
    }

    render() {

        var data = localStorage.getItem('myData');
        console.log("data in label", data);

        this.state.Email = data;
        const get = this.state.notes.map(key => {
            return (
                (key.Email === this.state.Email) &&
                <div className='label-adding'>
                    <MenuItem onClick={()=>this.handleClick(key.Label)}>
                        <LabelOutlinedIcon />
                        <div>{key.Label}</div>
                    </MenuItem>
                </div>
            )
        })
        return (
            <div className='label-list'>
                {get}
            </div>
        )
    }

}
export default withRouter(LabelComponent)
