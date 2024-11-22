import React from "react";
import { DataGrid, GridColDef } from "@mui/x-data-grid";

const CrudApp: React.FC = () => {
    const rows = [
        { id: 1, name: "John Doe", age: 30 },
        { id: 2, name: "Jane Smith", age: 25 },
        { id: 3, name: "Alice Johnson", age: 35 },
    ];

    const columns: GridColDef[] = [
        { field: "id", headerName: "ID", width: 90 },
        { field: "name", headerName: "Name", width: 150 },
        { field: "age", headerName: "Age", type: "number", width: 110 },
    ];

    return (
        <div style={{ height: 400, width: "100%" }}>
            <h2>CRUD Page</h2>
            <DataGrid rows={rows} columns={columns} pageSize={5} rowsPerPageOptions={[5]} />
        </div>
    );
};

export default CrudApp;
