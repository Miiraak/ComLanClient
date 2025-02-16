# ComLan
<p align="center">
  <img src="/.github/Images/channel.png">
</p>
  
## Description
ComLan is a small portable lan communication client.
*Need to have a ComlanServer running on the network.*

## Features
- **Custom Username**: Possibility to set a custom username or letting empty to use Environment.Username
- **Encrypted communication**: Encrypted communication with Aes-256-Cbc. Use a default key. This can be change at login.
- ...

### In Dev/Idea
|Label :|Desc :|
|---|---|
| **Secure communication** | To secure the communication between cli/server by adding SSL. | 
| **Sending files** | Allowing user to send file on the main channel. |
| **Multi-Channel** | Let user create channel with other servers or clients. |
| **Connected user list**| Allow user to see who is connected to the server and create channel with choosen ones. |
| **in work...** | ...

## Usage
*Starting server :*
- Download and run : [ComlanServer](https://github.com/Miiraak/ComlanServer).

*Starting client :*
- Download and run ComLan.
- Username : Set a custom name. *(if empty session username will be used.)*
- ServerIP : Put the ip show in ComlanServer GUI.
- ServerPort : Set the server's listening port show in ComlanServer GUI. *(by default 8888)*
- Aes Key : Set the 32 char Key used to encrypt/Decrypt the message. *(If empty a predefined key will be used.)*

![login](/.github/Images/Login.png)
  
- Click connect.
- If all right, the channel show "Server connexion : OK." 

## Issues and Suggestions
If you encounter any issues or have suggestions for improving the project, please use the [GitHub issue tracker](https://github.com/Miiraak/ComlanClient/issues).

## License
This project is licensed under the MIT. See the [LICENSE](./LICENSE) file for more details.

## Contributors
- **[Miiraak](https://github.com/miiraak)** - *Lead Developer*
- **[Doncadavona](https://gist.github.com/doncadavona)** - for the [Aes-256-Cbc](https://gist.github.com/doncadavona/19bf1423daf2790276dc0a823cd8c579)
- **[Elimad](https://stackoverflow.com/users/2745573/elimad)** - for the [Borderless movable form](https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable)
- *Others* - Look in **[Attribution](/.github/Attribution_Links.md)**
