import React, { Component } from 'react'
import { createMuiTheme, MuiThemeProvider, Card } from '@material-ui/core';
import AppBar from '@material-ui/core/AppBar';
import { withRouter } from 'react-router-dom'
import Button from '@material-ui/core/Button';

const theme = createMuiTheme({
    overrides: {
        MuiAppBar: {
            colorPrimary: {
                color: "black",
                backgroundColor: "lightblue",
            }
        },
        MuiCard: {
            root: {
                overflow: "visible",
            }
        }
    }
})
class CardComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            serviceData: [],
            open: false,
            price: 0,
            value: 0,
            mouseEnter: false,
            cartId: '',
            cart: '',
            pId: '',
            name: '',
            id: ''
        }
    }
    
    handleSignIn = () => {
        this.props.history.push('/login');
    }
    handleCardOpen = () => {
        this.setState({
            open: !this.state.open,
        })
    }
    handleRemove = () => {
        this.setState({
            open: false
        })
    }
    handleChange = (event, value) => {
        this.setState({ value });
    };
  
    handleMouseEntry = (id) => {
        this.setState({
            mouseEnter: true,
            cartId: id
        })
    }
    handleMouseExit = () => {
        this.setState({
            mouseEnter: false
        })
    }
    handleCardClick=(id)=>{
        this.props.props.history.push('/register',id)
    }
   
      
    render() {
        return (
            this.props.cardProps?
             <div className="service-card">
                    {
                        (this.props.card1===1)?
                        <div className="first-outer">
                    
                        <MuiThemeProvider theme={theme}>

                            <Card style={{ backgroundColor: this.props.card1===1?"orange":"blue"  }}  this className="outerCard"   >

                                  <Card className="innerCard" >
                                  <div className="data-service-card">
                                    <div>
                                        <h4>
                                            <b> price: $99 per month   </b>
                                        </h4>
                                    </div>
                                    <div style={{ color: "blue" }}>
                                        <b> Advance</b>
                                    </div>
                                    <h6 >
                                        <div >
                                            * $99/month
                                    </div>
                                        <div>
                                            * Ability to add title, description, images, labels, checklist and colors
                                    </div>
                                    </h6>
                                    </div>
                                </Card>
                                {this.props.card1===1?(
                                <div className="add-cart" ><h5>{this.props.status}</h5></div>
                                ):
                                <div className="add-cart" ><h5>Add To Cart</h5></div>}
                            </Card>
                        </MuiThemeProvider>

                    </div>
                    :
                    <div className="first-outer">
                        <MuiThemeProvider theme={theme}>
                            <Card style={{ backgroundColor: this.props.card2===2?"orange":"blue"  }} className="outerCard" >

                                <Card className="innerCard" >
                                <div className="data-service-card">
                                    <div>
                                        <h4>
                                            <b> price: $49 per month   </b>
                                        </h4>
                                    </div>

                                    <div style={{ color: "blue" }}>

                                        <b> Basic</b> </div><h6>
                                        <div >
                                            * $49/month </div>
                                        <div>
                                            * Ability to add title, description, images, labels, checklist and colors </div>
                                    </h6>
                                    </div>
                                </Card>
                                {this.props.card2===2?(
                                    <div className="add-cart" ><h5>{this.props.status}</h5></div>
                                    ):
                                    <div className="add-cart" ><h5>Add To Cart</h5></div>}
                            </Card>
                        </MuiThemeProvider>
                    </div>}
                </div>
                :
            <div className="service-card-main">
                <div>
                    <MuiThemeProvider theme={theme}>
                        <AppBar style={{ height: "65px" }} position="static" color="primary">
                            <h2 className='fundooNotes'>Fundoo Notes</h2>
                            
                        </AppBar>
                    </MuiThemeProvider>
                </div>
                <div className="head">
                    <h5 style={{ textAlign: "center", fontFamily: "Times New Roman", wordSpacing: "5px" }}>
                        <b>Fundoo Notes offered. Choose below service to Register.</b>
                    </h5>
                </div>
                <div className="service-card-static">
                    <div className="first-outer-static">
                        <MuiThemeProvider theme={theme}>

                            <Card  style={{ backgroundColor: "lightblue" }} className="outerCard" onClick={()=>this.handleCardClick(1)} >

                                  <Card className="innerCard" >
                                  <div className="data-service-card">
                                    <div>
                                        <h4>
                                            <b> price: $99 per month   </b>
                                        </h4>
                                    </div>
                                    <div style={{ color: "blue" }}>
                                        <b> Advance</b>
                                    </div>
                                    <h6 >
                                        <div >
                                            * $99/month
                                    </div>
                                        <div>
                                            * Ability to add title, description, images, labels, checklist and colors
                                    </div>
                                    </h6>
                                    </div>
                                </Card>
                                <div className="add-cart" ><h5>Add To Cart</h5></div>
                            </Card>
                        </MuiThemeProvider>
                    </div>
                    <div className="first-outer-static">
                        <MuiThemeProvider theme={theme}>
                            <Card style={{ backgroundColor: "lightblue" }} className="outerCard" onClick={()=>this.handleCardClick(2)}>

                                <Card className="innerCard" >
                                <div className="data-service-card">
                                    <div>
                                        <h4>
                                            <b> price: $49 per month   </b>
                                        </h4>
                                    </div>

                                    <div style={{ color: "blue" }}>

                                        <b> Basic</b> </div><h6>
                                        <div >
                                            * $49/month </div>
                                        <div>
                                            * Ability to add title, description, images, labels, checklist and colors </div>
                                    </h6>
                                    </div>
                                </Card>
                                <div >
                                    <div className="add-cart"><h5>Add To Cart</h5></div>
                                </div>
                            </Card>
                        </MuiThemeProvider>
                    </div>
                </div>
                <div className="serviceLogin">
                    <Button variant="contained" color="secondary" onClick={this.handleSignIn}>  Sign in instead</Button>
                </div>
            </div>
 
        )
    }
}
export default withRouter(CardComponent)
