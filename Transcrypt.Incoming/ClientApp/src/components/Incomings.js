import React, { Component } from 'react';

import AddCircleOutlineIcon from '@material-ui/icons/AddCircleOutline';
import AutoRenewIcon from '@material-ui/icons/Autorenew';
import Button from '@material-ui/core/Button';
import TextField from '@material-ui/core/TextField';
import Grid from '@material-ui/core/Grid';
import SearchIcon from '@material-ui/icons/Search';
import CircularProgress from '@material-ui/core/CircularProgress';
import Snackbar from '@material-ui/core/Snackbar';
import IconButton from '@material-ui/core/IconButton';
import CloseIcon from '@material-ui/icons/Close';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import TableFooter from '@material-ui/core/TableFooter';

const loading_container = {
    textAlign: "center"
};

export class Incomings extends Component {
    constructor(props) {
        super(props);

        this.state = {
            isLoading: false,
            page: 1,
            records: [],
            errorMessageOpen: false
        };
    }

  render() {
    var tableBody = <TableBody>
        <TableRow>
            <TableCell colSpan={3}>
                <div style={loading_container}>
                    There is no data
				</div>
            </TableCell>
        </TableRow>
    </TableBody>;

    if (this.state.isLoading == true) {
        tableBody = <TableBody>
            <TableRow>
                <TableCell colSpan={3}>
                    <div style={loading_container}>
                        <CircularProgress />
                    </div>
                </TableCell>
            </TableRow>
        </TableBody>;
    }

    if (this.state.records.length > 0) {
        tableBody = <TableBody>
            {this.state.records.map(row => {
                return (
                    <TableRow key={row.id}>
                        <TableCell component="th" scope="row">
                            {row.id}
                        </TableCell>
                        <TableCell>
                            {row.title}
                        </TableCell>
                        <TableCell>{row.receivedDate}</TableCell>
                    </TableRow>
                );
            })}
        </TableBody>;
    }

    var appendButton = <div style={loading_container}>
        <Button variant="fab" onClick={() => this.handleAppend()}>
            <AutoRenewIcon />
        </Button>
    </div>;

      return <div style={{ textAlign: 'center' }}>
          <br />
          <Table>
              <TableHead>
                  <TableRow>
                      <TableCell>
                          DocumentId
							</TableCell>
                      <TableCell>
                          Title
							</TableCell>
                      <TableCell numeric>
                          ReceivedDate
					    </TableCell>
                  </TableRow>
              </TableHead>
              {tableBody}
              <TableFooter>
                  <TableRow>
                      <TableCell colSpan={3}>
                          {appendButton}
                      </TableCell>
                  </TableRow>
              </TableFooter>
          </Table>
          <Snackbar
              anchorOrigin={{
                  vertical: 'bottom',
                  horizontal: 'left',
              }}
              open={this.state.errorMessageOpen}
              autoHideDuration={6000}
              onClose={(event, reason) => this.handleClose(event, reason)}
              ContentProps={{
                  'aria-describedby': 'message-id',
              }}
              message={<span id="message-id">There is sothing wrang!</span>}
              action={[
                  <IconButton key="close" aria-label="Close" color="inherit" onClick={(event) => this.handleClose(event, null)}>
                      <CloseIcon />
                  </IconButton>,
              ]}
          />
      </div>;
    };
    
    handleClose(event, reason) {
        if (reason == 'clickaway') {
            return;
        }

        this.setState({ errorMessageOpen: false });
    };

    handleAppend() {
        this.pullData(true);
    }

    handleSearch() {
        this.pullData(false);
    }

    pullData(append) {
        this.setState({
            isLoading: true
        });

        fetch('api/Docs/Get?page=' + this.state.page).then(response => response.json())
            .then(data => {

                var newPage = this.state.page + 1;

                if (append == true) {
                    this.setState({
                        page: newPage,
                        records: this.state.records.concat(data),
                        isLoading: false
                    });
                } else {
                    this.setState({
                        page: newPage,
                        records: data,
                        isLoading: false
                    });
                }
            });
    }

    componentDidMount() {
        this.pullData(false);
    }
}
