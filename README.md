# Block Diagram Application

## About the project

Block Diagram App is simple block diagram editor for describing simple algorithms. I used Windows Forms to keep a balance between the functionality and the appearance of the application.

![Example block diagram](https://user-images.githubusercontent.com/102852926/187023109-c6c29183-1379-4170-b7bc-c67ab19bb891.png)

### Technology

- [.NET 5.0](https://docs.microsoft.com/en-us/dotnet/core/whats-new/dotnet-5)
- [C# 9.0](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9)
- [Windows Forms](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-5.0)

### Features

- Window divided into two panels
  - left panel with the bitmap
  - right panel with the tools

<!-- <br/> -->

- Creating, saving and loading diagrams
- Adding, linking, deleting blocks

<!-- <br/> -->

- Four fixed-size blocks available:
  - start block
    - with one output node at the bottom
    - only one such block can be used in one schema
  - stop block with
    - one input node at the top
  - operation block - rectangle with
    - one input node at the top
    - one output node at the bottom
    - editable text inside
  - decision block - diamond-shaped block with
    - one input node at the top
    - two output nodes on the sides
    - editable text inside

- Selecting blocks - **right mouse button**
- Moving the selected block (along its links to the other blocks) by pressing the **middle mouse button** and moving the mouse
- Editing text of the selected block

![Editing text of the selected block](https://user-images.githubusercontent.com/102852926/187023902-c058daba-0dac-4e52-9dc2-0b083e4406e3.png)

### Features to implement in the future

- Language changing (using Windows Forms Localization)

<br/>

## Contact

- Linkedin: [Mikołaj Nowak](https://www.linkedin.com/in/nowak-mikolaj-f/)
- Email: nowak.mikolaj19@gmail.com
