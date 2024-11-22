import React, { useState, useEffect } from "react";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import { Button, Modal, TextField } from "@mui/material";

type User = {
    id: number;
    name: string;
    email: string;
};

const API_URL = "https://localhost:7147/api/Authors";

const CrudApp: React.FC = () => {
    const [users, setUsers] = useState<User[]>([]);
    const [loading, setLoading] = useState<boolean>(true);
    const [open, setOpen] = useState<boolean>(false);
    const [newUser, setNewUser] = useState<User | null>(null);

    useEffect(() => {
        const fetchUsers = async () => {
            const response = await fetch(API_URL);
            const data: User[] = await response.json();
            setUsers(data);
            setLoading(false);
        };
        fetchUsers();
    }, []);

    const handleDelete = async (id: number) => {
        await fetch(`${API_URL}/${id}`, { method: "DELETE" });
        setUsers(users.filter((user) => user.id !== id));
    };

    const handleCreateOrUpdate = async () => {
        if (newUser) {
            const method = newUser.id ? "PUT" : "POST";
            const url = newUser.id ? `${API_URL}/${newUser.id}` : API_URL;

            const response = await fetch(url, {
                method,
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(newUser),
            });

            const updatedUser = await response.json();
            if (method === "POST") setUsers([...users, updatedUser]);
            else setUsers(users.map((user) => (user.id === updatedUser.id ? updatedUser : user)));

            setOpen(false);
            setNewUser(null);
        }
    };

    const columns: GridColDef[] = [
        { field: "id", headerName: "ID", width: 70 },
        { field: "name", headerName: "Name", width: 130 },
        { field: "email", headerName: "Email", width: 200 },
        {
            field: "actions",
            headerName: "Actions",
            width: 200,
            renderCell: (params) => (
                <>
                    <Button
                        onClick={() => {
                            setNewUser(params.row);
                            setOpen(true);
                        }}
                        color="primary"
                        variant="outlined"
                        size="small"
                    >
                        Edit
                    </Button>
                    <Button
                        onClick={() => handleDelete(params.row.id)}
                        color="secondary"
                        variant="outlined"
                        size="small"
                        style={{ marginLeft: "10px" }}
                    >
                        Delete
                    </Button>
                </>
            ),
        },
    ];

    return (
        <div style={{ height: 400, width: "100%" }}>
            <Button
                onClick={() => {
                    setNewUser({ id: 0, name: "", email: "" });
                    setOpen(true);
                }}
                color="primary"
                variant="contained"
                style={{ marginBottom: "10px" }}
            >
                Add New User
            </Button>
            <DataGrid rows={users} columns={columns} loading={loading} />
            <Modal open={open} onClose={() => setOpen(false)}>
                <div style={{ padding: "20px", backgroundColor: "white", margin: "100px auto", width: "300px" }}>
                    <h2>{newUser?.id ? "Edit User" : "Add User"}</h2>
                    <TextField
                        label="Name"
                        value={newUser?.name || ""}
                        onChange={(e) => setNewUser({ ...newUser, name: e.target.value } as User)}
                        fullWidth
                        style={{ marginBottom: "10px" }}
                    />
                    <TextField
                        label="Email"
                        value={newUser?.email || ""}
                        onChange={(e) => setNewUser({ ...newUser, email: e.target.value } as User)}
                        fullWidth
                        style={{ marginBottom: "10px" }}
                    />
                    <Button onClick={handleCreateOrUpdate} color="primary" variant="contained">
                        Save
                    </Button>
                </div>
            </Modal>
        </div>
    );
};

export default CrudApp;
