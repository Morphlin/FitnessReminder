!include "MUI2.nsh"
;--------------------------------
; The name of the installer
Name "Fitness Reminder"

; The file to write
OutFile "bin\Debug\FitnessReminderInstall.exe"

; The default installation directory
InstallDir "$APPDATA\Gartech\Fitness Reminder"

; Registry key to check for directory (so if you install again, it will 
; overwrite the old one automatically)
InstallDirRegKey HKCU "Software\Gartech\Fitness Reminder" ""

; Request application privileges for Windows Vista
RequestExecutionLevel user

;--------------------------------
;Languages 
!insertmacro MUI_LANGUAGE "English"

;--------------------------------
;Variables
  Var StartMenuFolder

;--------------------------------
;Interface Settings
  !define MUI_ABORTWARNING

;--------------------------------
; Pages
!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_LICENSE "LICENSE"
!insertmacro MUI_PAGE_DIRECTORY

;Start Menu Folder Page Configuration
!define MUI_STARTMENUPAGE_REGISTRY_ROOT "HKCU" 
!define MUI_STARTMENUPAGE_REGISTRY_KEY "Software\Modern UI Test" 
!define MUI_STARTMENUPAGE_REGISTRY_VALUENAME "Start Menu Folder"

!insertmacro MUI_PAGE_STARTMENU Application $StartMenuFolder
!insertmacro MUI_PAGE_INSTFILES

!insertmacro MUI_UNPAGE_WELCOME
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

# installer section start
Section "install"
 
    # set the installation directory as the destination for the following actions
    SetOutPath $INSTDIR
	
	# define what to install and place it in the output path
	File "bin\Debug\Fitness Reminder.exe"
 
    # create the uninstaller
    WriteUninstaller "$INSTDIR\uninstall.exe"
	
    # create a shortcut named "new shortcut" in the start menu programs directory
    # point the new shortcut at the program uninstaller
    CreateShortCut "$SMPROGRAMS\$StartMenuFolder\Fitness Reminder.lnk" "$INSTDIR\Fitness Reminder.exe"
 
    # create a shortcut named "new shortcut" in the start menu programs directory
    # point the new shortcut at the program uninstaller
    CreateShortCut "$SMPROGRAMS\$StartMenuFolder\Uninstall Fitness Reminder.lnk" "$INSTDIR\uninstall.exe"
 
	# registry key creation for directory
	WriteRegStr HKCU "Software\Gartech\Fitness Reminder" "" $INSTDIR
	
# installer section end
SectionEnd
 
# uninstaller section start
Section "uninstall"
	
	# delete the program
	Delete "$INSTDIR\Fitness Reminder.exe"
 
    # delete the uninstaller
    Delete "$INSTDIR\uninstall.exe"

	# delete application folder
	RMDir "$INSTDIR"

	# get start menu name chosen at install
	!insertmacro MUI_STARTMENU_GETFOLDER Application $StartMenuFolder
 
    # remove the link from the start menu
    Delete "$SMPROGRAMS\$StartMenuFolder\Fitness Reminder.lnk"
 
    # remove the link from the start menu
    Delete "$SMPROGRAMS\$StartMenuFolder\Uninstall Fitness Reminder.lnk"
	
	# remove the start menu directory
	RMDir "$SMPROGRAMS\$StartMenuFolder"

	# registry key deletion
	DeleteRegKey /ifempty HKCU "Software\Gartech\Fitness Reminder"
 
# uninstaller section end
SectionEnd