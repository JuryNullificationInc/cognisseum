import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import CognisseumHome from './routes/CognisseumHome';

const Routing = () => {
    return (
        <Router>
            <Routes>
                <Route path="/" Component={CognisseumHome} />
            </Routes>
        </Router>
    )
}


ReactDOM.render(
    <React.StrictMode>
        <Routing />
    </React.StrictMode>,
    document.getElementById('root')
);