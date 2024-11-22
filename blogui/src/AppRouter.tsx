import React from "react";
import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import Home from "./pages/Home";
import CrudApp from "./pages/CrudApp";
import About from "./pages/About";
import AuthorManagement from "./CrudApp";

const AppRouter: React.FC = () => {
    return (
        <Router>
            <div style={{ textAlign: "center", margin: "20px" }}>
                <h1>Central Navigation Page</h1>
                <nav>
                    <Link to="/" style={{ margin: "10px" }}>Home</Link>
                    <Link to="/crud" style={{ margin: "10px" }}>CRUD App</Link>
                    <Link to="/about" style={{ margin: "10px" }}>About</Link>
                    <Link to="/AuthorManagement" style={{ margin: "10px" }}>Author Management</Link>
                </nav>
                <Routes>
                    <Route path="/" element={<Home />} />
                    <Route path="/crud" element={<CrudApp />} />
                    <Route path="/about" element={<About />} />
                    <Route path="/AuthorManagement" element={<AuthorManagement />} />
                </Routes>
            </div>
        </Router>
    );
};

export default AppRouter;
