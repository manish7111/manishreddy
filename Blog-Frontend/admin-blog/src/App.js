import React, { Component } from 'react';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import './App.css';
import GetAllProducts from './Components/getAllProducts';
import ReduxProduct from './Components/ReduxProduct';
import Buy from './Components/buy';
import dashboard from './Components/dashboard';
import Address from './Components/Address';
import ReduxLogin from './Components/ReduxLogin';
import { Provider } from "react-redux";
import store from '../src/Store/Store'

class App extends Component {
  render() {
    return (
      <div className="App-side">
        <Provider store={store}>
          <Router>
            <Switch>
              <Route path='/admin' component={GetAllProducts}></Route>
              <Route path='/product' component={ReduxProduct}></Route>
              <Route path='/buy' component={Buy}></Route>
              <Route path='/dashboard' component={dashboard}></Route>
              <Route path='/address' component={Address}></Route>
              <Route path='/' component={ReduxLogin} exact={true}></Route>
            </Switch>
          </Router>
        </Provider>
      </div>
    );
  }
}
export default App;

