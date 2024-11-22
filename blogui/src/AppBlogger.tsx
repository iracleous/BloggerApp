import { useEffect, useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'


type Author = {
    id: number;
    name: string;
    email: string;
};

const API_URL = "https://localhost:7147/api/Authors";


const fetchUsers = async (apiUrl: string): Promise<Author[]> => {
    const response = await fetch(apiUrl);

    if (!response.ok) {
        throw new Error(`Error: ${response.status} ${response.statusText}`);
    }

    return response.json();
};



function AppBlogger() {
    const [users, setUsers] = useState<Author[]>([]);
    const [loading, setLoading] = useState<boolean>(true);
    const [error, setError] = useState<string | null>(null);

    useEffect(() => {
        const getUsers = async () => {
            try {
                const data = await fetchUsers(API_URL); // Call the function with the URL
                setUsers(data);
            } catch (err: any) {
                setError(err.message || "Unknown error occurred");
            } finally {
                setLoading(false);
            }
        };

        getUsers();
    }, [API_URL]); // Dependency array

    if (loading) return <p>Loading...</p>;
    if (error) return <p>Error: {error}</p>;

    return (
        <ul>
            {users.map((user) => (
                <li key={user.id}>
                    <strong>{user.name}</strong> - {user.email}
                </li>
            ))}
        </ul>
    );
};

export default AppBlogger;
