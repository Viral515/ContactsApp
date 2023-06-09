#define SETUPFILENAME = "ContactsApp_" + GetDateTimeString('yyyy/mm/dd','','') + "_setup"

[Setup]
AppId={{4558E2B9-5149-47B2-B0C0-A7ECF45FCF32}
AppName=ContactsApp
AppVersion=1.1
AppPublisher=Shatylo, Inc.
AppPublisherURL=https://github.com/Viral515
AppSupportURL=https://github.com/Viral515
AppUpdatesURL=https://github.com/Viral515
DefaultDirName={autopf}\/Shatylo/ContactsApp
ChangesAssociations=yes
DefaultGroupName=ContactsApp
AllowNoIcons=yes
OutputDir=.\Output
OutputBaseFilename={#SETUPFILENAME}
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\src\ContactsApp\ContactsApp.View\bin\Debug\ContactsApp.View.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\src\ContactsApp\ContactsApp.View\bin\Debug\*.dll"; DestDir: "{app}";


[Registry]
Root: HKA; Subkey: "Software\Classes\.myp\OpenWithProgids"; ValueType: string; ValueName: "ContactsAppFile.myp"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\ContactsAppFile.myp"; ValueType: string; ValueName: ""; ValueData: "ContactsApp File"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\ContactsAppFile.myp\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\ContactsApp.View.exe,0"
Root: HKA; Subkey: "Software\Classes\ContactsAppFile.myp\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\ContactsApp.View.exe"" ""%1"""
Root: HKA; Subkey: "Software\Classes\Applications\ContactsApp.View.exe\SupportedTypes"; ValueType: string; ValueName: ".myp"; ValueData: ""

[Icons]
Name: "{group}\ContactsApp"; Filename: "{app}\ContactsApp.View.exe"
Name: "{autodesktop}\ContactsApp"; Filename: "{app}\ContactsApp.View.exe"; Tasks: desktopicon

[Run]
Filename: "{app}\ContactsApp.View.exe"; Description: "{cm:LaunchProgram,ContactsApp}"; Flags: nowait postinstall skipifsilent
