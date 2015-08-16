!include "MUI2.nsh"
!define /ifndef VERSION '1.0.2'
;--------------------------------
; Installer info

; The name of the installer
Name "Fitness Reminder"

; The file to write
OutFile "bin\Debug\FitnessReminder_v${VERSION}.exe"

; The default installation directory
InstallDir "$APPDATA\Gartech\Fitness Reminder"

; Registry key to check for directory (so if you install again, it will 
; overwrite the old one automatically)
InstallDirRegKey HKCU "Software\Gartech\Fitness Reminder" ""

; Request application privileges for Windows Vista
RequestExecutionLevel user

ShowInstDetails show
ShowUninstDetails show

;--------------------------------
;Version Information

VIProductVersion ${VERSION}.0
VIAddVersionKey "ProductName" "Fitness Reminder"
VIAddVersionKey "FileDescription" "Reminder to workout every now and then when working on the computer."
VIAddVersionKey "CompanyName" "Garnote-Technologies"
VIAddVersionKey "LegalCopyright" "Copyright © Gartech 2015"
VIAddVersionKey "LegalTrademarks" "2015-08-16"
VIAddVersionKey "ProductVersion" "${VERSION}"
VIAddVersionKey "FileVersion" "${VERSION}"
VIAddVersionKey "Comments" ""
  
;--------------------------------
;Interface Settings
!define MUI_ABORTWARNING

!define MUI_HEADERIMAGE
!define MUI_HEADERIMAGE_BITMAP "${NSISDIR}\Contrib\Graphics\Header\nsis.bmp"
!define MUI_WELCOMEFINISHPAGE_BITMAP "${NSISDIR}\Contrib\Graphics\Wizard\nsis.bmp"

!define MUI_WELCOMEPAGE_TITLE "Welcome to the Fitness Reminder v${VERSION} Setup Wizard"
!define MUI_WELCOMEPAGE_TEXT "This wizard will guide you through the installation of Fitness Reminder v${VERSION}, a light weight utility to remember to workout every now and then when working on the computer.$\r$\n$\r$\n$_CLICK"

!define MUI_COMPONENTSPAGE_NODESC

!define MUI_FINISHPAGE_RUN "$INSTDIR\Fitness Reminder.exe"
!define MUI_FINISHPAGE_RUN_TEXT "Launch Fitness Reminder"
!define MUI_FINISHPAGE_NOREBOOTSUPPORT

!define MUI_FINISHPAGE_LINK "Source code available on GitHub."
!define MUI_FINISHPAGE_LINK_LOCATION "https://github.com/Morphlin/FitnessReminder"

;--------------------------------
; Pages
!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_LICENSE "LICENSE"
!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_PAGE_FINISH

!insertmacro MUI_UNPAGE_WELCOME
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES
!insertmacro MUI_UNPAGE_FINISH

;--------------------------------
;Languages 
!insertmacro MUI_LANGUAGE "English"

;--------------------------------
# installer sections
Section "Program"

	SectionIn RO
	
	SetOverwrite on
    # set the installation directory as the destination for the following actions
    SetOutPath $INSTDIR	
	
	# define what to install and place it in the output path
	File "bin\Debug\Fitness Reminder.exe"
 
    # create the uninstaller
    WriteUninstaller "$INSTDIR\uninstall.exe"
 
	# registry key creation for directory
	WriteRegStr HKCU "Software\Gartech\Fitness Reminder" "" $INSTDIR
	
SectionEnd

Section "License"

	SectionIn RO
	SetOverwrite on
    # set the installation directory as the destination for the following actions
    SetOutPath $INSTDIR	
	# define what to install and place it in the output path
	File LICENSE	
	
SectionEnd

Section "Readme"

	SectionIn RO
	SetOverwrite on
    # set the installation directory as the destination for the following actions
    SetOutPath $INSTDIR
	# define what to install and place it in the output path
	File README.md
	
SectionEnd

Section "Start menu"

	SetOverwrite on
    # set the installation directory as the destination for the following actions
    SetOutPath $INSTDIR	
	# create a shortcut directory
    CreateDirectory "$SMPROGRAMS\Fitness Reminder"	
    # create a shortcut
    CreateShortCut "$SMPROGRAMS\Fitness Reminder\Fitness Reminder.lnk" "$INSTDIR\Fitness Reminder.exe" 
    # create a shortcut
    CreateShortCut "$SMPROGRAMS\Fitness Reminder\Uninstall Fitness Reminder.lnk" "$INSTDIR\uninstall.exe"
	
SectionEnd
# installer sections end
 
;--------------------------------
# uninstaller section start
Section "Uninstall"
	
	SectionIn RO
	ExecWait 'TaskKill /IM "Fitness Reminder.exe" /F'
	
	sleep 2000
	
	# delete the program
	Delete "$INSTDIR\Fitness Reminder.exe"
	Delete "$INSTDIR\LICENSE"
	Delete "$INSTDIR\README.md"
    Delete "$INSTDIR\uninstall.exe"
	RMDir "$INSTDIR"
 
    # remove the link from the start menu
    Delete "$SMPROGRAMS\Fitness Reminder\Fitness Reminder.lnk"
 
    # remove the link from the start menu
    Delete "$SMPROGRAMS\Fitness Reminder\Uninstall Fitness Reminder.lnk"
	
	# remove the start menu directory
	RMDir "$SMPROGRAMS\Fitness Reminder"

	# registry key deletion
	DeleteRegKey HKCU "Software\Gartech\Fitness Reminder"

	# registry value for auto-start deletion
	DeleteRegValue HKCU "Software\Microsoft\Windows\CurrentVersion\Run" "Fitness Reminder"
	
SectionEnd
# uninstaller section end