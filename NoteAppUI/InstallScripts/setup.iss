#define NoteAppExeName "NoteAppUI.exe"
#define AppName "NoteApp"
#define Date GetDateTimeString('dd mm yyyy hh nn', '', '')
#define AppVersion "1.2.0"
#define AppPublisher "Egor Kolencionok"

[Setup]
AppId={{61AC38E0-C611-425E-A55E-2A04F2F43582}
AppName = {#AppName}
AppVersion = {#AppVersion}
AppPublisher = {#AppPublisher}
DefaultDirName = {autopf}\{#AppName}
OutputDir = Installers
DisableProgramGroupPage = yes
OutputBaseFilename = setup{#Date}
Compression = lzma
SolidCompression = yes

[Languages]
Name: "en"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "Release\*.exe"; DestDir: "{app}" 
Source: "Release\*.dll"; DestDir: "{app}"

[Icons]
Name: "{autoprograms}\{#AppName}"; Filename: "{app}\{#NoteAppExeName}"; IconFilename: "{app}\{#NoteAppExeName}"
Name: "{autodesktop}\{#AppName}"; Filename: "{app}\{#NoteAppExeName}"; IconFilename: "{app}\{#NoteAppExeName}"; Tasks: desktopicon

