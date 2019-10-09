import React, { Component } from 'react'
import { IconButton, Paper, Popper, Tooltip, Card } from '@material-ui/core'
import { withRouter } from 'react-router-dom'
import ClickAwayListener from '@material-ui/core/ClickAwayListener';
import ColorLensOutlinedIcon from '@material-ui/icons/ColorLensOutlined';
const colorArray = [{ name: "default", colorCode: "#FDFEFE" },
{ name: "Salmon", colorCode: "#00CCCC" },
{ name: "Cyan", colorCode: "#999966" },
{ name: "Purple", colorCode: "#F5DEB3" },
{ name: "Teal", colorCode: "#D2B48C" },
{ name: "LightBlue", colorCode: "#BC8F8F" },
{ name: "Purple", colorCode: "#F4A460" },
{ name: "Yellow", colorCode: "#8B4513" },
{ name: "Lime", colorCode: "#A52A2A" },
{ name: "Magenta", colorCode: "#FFF8DC" },
{ name: "Silver", colorCode: "#1E90FF" },
{ name: "DarkKhaki", colorCode: "#BDB76B" },
]
class ColorPalletComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            anchorEL: false

        }
    }
    closePopper = () => {
        this.setState({
            open: false

        })
    }
    handleToggle = (event) => {
        this.setState({
            anchorEL: this.state.anchorEL ? false : event.target

        });
        // this.props.handleToggle(!this.state.open)
    }
    handleChangeColor =async (event) => {
console.log("event log",event.target.value);
console.log("note id"+this.props.noteId);

     await   this.props.colorProps(event.target.value,this.props.noteId,this.props.Title,this.props.Desc,this.props.Reminder,this.props.SenderEmail,this.props.ReceiverEmail,this.props.Label,this.props.Image)
    }
    render() {
        const getColor = colorArray.map((key) => {
            return (
                <Tooltip title={key.name}  style={{ zIndex: "9999",  width: "34%" ,display: "flex",justifyContent: "center",flexWrap: "wrap",marginLeft:"31%"}}>
                    <IconButton style={{ backgroundColor: key.colorCode, margin: "2px", zIndex: "9999" }}
                        value={key.colorCode}
                        onClick={this.handleChangeColor} />
                </Tooltip>
            )
        });
        return (

            <div>
                <ColorLensOutlinedIcon onClick={this.handleToggle} />

                <Popper open={this.state.anchorEL} anchorEl={this.state.anchorEL} style={{ zIndex: "9999" }}>
                    <Paper style={{ zIndex: "9999" }}>

                        {getColor}

                    </Paper>
                </Popper>


            </div>
        )
    }
}
export default withRouter(ColorPalletComponent)
