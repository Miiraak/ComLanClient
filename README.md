# ComLan

![channel](/.github/Images/channel.png)

## Description
ComLan is a small portable lan communication client.
*Need to have a ComlanServer running on the network.*

## Features
- **Custom Username**: Possibility to set a custom username or letting empty to use Environment.Username
- **Encrypted communication**: Encrypted communication with Aes-256-Cbc. Use a default key. This can be change at login.
- ...

### Features in development
|||
|---|---|
| **Secure communication** | To secure the communication between users. | 
| **Sending files** | Allowing user to send file on the main channel. |
| **in work...** | ...

## Usage
*Starting server :*
- Download and run : [ComlanServer](https://github.com/Miiraak/ComlanServer).

*Starting client :*
- Download and run ComLan.
- Username : Set a custom name. *(if empty session username will be used.)*
- ServerIP : Put the ip of the PC running ComlanServer.
- ServerPort : Set the server's listening port. *(by default 8888)*
- Aes Key : Set the 32 char Key used to encrypt/Decrypt the message. *(If empty a predefined key will be used.)*

![login](/.github/Images/Login.png)
  
- Click connect.
- If all right, the channel show "Server connexion : OK." 

## Contributing
Contributions are welcome! To contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature (`git checkout -b my-new-feature`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add my new feature'`).
5. Push your branch (`git push origin my-new-feature`).
6. Open a Pull Request.

## Issues and Suggestions
If you encounter any issues or have suggestions for improving the project, please use the [GitHub issue tracker](https://github.com/Miiraak/ComlanClient/issues).

## License
This project is licensed under the [MIT]. See the [LICENSE](./LICENSE) file for more details.

## Contributors
- **[Miiraak](https://github.com/miiraak)** - *Lead Developer*
- **[Doncadavona](https://gist.github.com/doncadavona)** - for the [Aes-256-Cbc](https://gist.github.com/doncadavona/19bf1423daf2790276dc0a823cd8c579)
- *Others* - Look in **[Attribution](/.github/Attribution_Links.md)**
