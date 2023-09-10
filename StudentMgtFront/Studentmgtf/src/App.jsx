import React, { useEffect, useState } from 'react';

import './App.css'

import axios from 'axios';
import {
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Paper,
} from '@mui/material';

const DataTable  = () => {
  const [data, setData] = useState([]);

  
const options = {
  filterType: 'checkbox',
};


  useEffect(() => {
    // Replace 'your-api-endpoint' with the actual API endpoint
    axios.get('https://localhost:7019/api/Student')
      .then((response) => {
        setData(response.data);
      })
      .catch((error) => {
        console.error('Error fetching data:', error);
      });
  }, []);

  return (
    <TableContainer component={Paper}>
      <Table>
        <TableHead>
          <TableRow>
            <TableCell>ID</TableCell>
            <TableCell>Name</TableCell>
            <TableCell>Email</TableCell>
            <TableCell>strStudentMobileNo</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {data.map((row) => (
            <TableRow key={row.intId}>
              <TableCell>{row.strStudentId}</TableCell>
              <TableCell>{row.strStudentName}</TableCell>
              <TableCell>{row.strStudentEmail}</TableCell>
              <TableCell>{row.strStudentMobileNo}</TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
};

export default DataTable
