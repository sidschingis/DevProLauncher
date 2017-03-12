﻿using System;

namespace DevProLauncher.Config
{
    [Serializable]
    public class LanguageInfo
    {
        // Quickhost frm
        public string QuickHostSetting = "Quick Host Settings";

        public string QuickHostBtn = "Confirm";

        // Program.cs
        public string pmsbProgRun = "Program already running";

        public string pMsbErrorToServer = "Error Connecting to server";
        public string pMsbBadLog = "Bad Login";
        public string pMsbOldVers = "You have a very old version of the launcher. Do you want to reinstall?";
        public string pMsbException = "Oooops! Something bad happened! Software will now exit!";

        // Login_frm.cs
        public string LoginUserName = "Username";

        public string LoginPassWord = "Password";
        public string LoginLanguage = "Language";
        public string LoginLoginButton = "Login";
        public string LoginRegisterButton = "Register";
        public string LoginValidateButton = "Validate";
        public string LoginRecoverButton = "Recover";
        public string LoginAutoLogin = "Log me in automatically next time";
        public string LoginMsb1 = "Not connected to the server.";
        public string LoginMsb2 = "Please enter username.";
        public string LoginMsb3 = "Please enter password.";
        public string LoginSavePass = "Save Password";
        public string LoginInvalid = "You need to validate your account.";
        public string LoginFailed = "Incorrect Password or Username.";
        public string LoginBanned = "You are banned.";

        // Register_frm.cs
        public string RegistLbUser = "Username";

        public string RegistLbPw = "Password";
        public string RegistLbPw2 = "Confirm Password";
        public string RegistLbMail = "Email";
        public string RegistLbMail2 = "Confirm Email";
        public string RegistBtnRegister = "Register";
        public string RegistBtnCancel = "Cancel";
        public string RegistMsb1 = "Please confirm your password";
        public string RegistMsb2 = "Please enter password";
        public string RegistMsb3 = "Please enter username.";
        public string RegistMsb4 = "Registering Complete!";
        public string RegistMsb5 = "This username has been taken.";
        public string RegistMsb6 = "Username cannot contain special characters";
        public string RegistMsb7 = "Email address reqired.";
        public string RegistMsb8 = "Invalid email address.";
        public string RegistPassError = "Passwords do not match.";
        public string RegistMailError = "Email addresses do not match";
        public string RegistMailExists = "Email address already exists";
        public string RegistMailBlacklist = "Email is blacklisted";
        public string RegistNameBlackList = "Your name is illegal";
        public string RegistMailFormat = "Invalid Email format";

        // Validate_frm.cs

        public string ValidateLbUser = "Username";
        public string ValidateLbCode = "Code";
        public string ValidateBtnSubmit = "Submit";
        public string ValidateBtnCancel = "Cancel";
        public string ValidateBtnResend = "Resend";
        public string ValidateMsbUsername = "Please enter your username.";
        public string ValidateMsbEmail = "Please enter your email address.";
        public string ValidateMsbCode = "Please enter your code.";
        public string ValidateMsbResendOK = "Request accepted, the email may take some time to arrive.";
        public string ValidateMsbResendFail = "Resend failed (wrong Username/Email address).";
        public string ValidateMsbAccept = "Account Validated.";
        public string ValidateMsbFailed = "Validation failed (wrong Username/Code combination).";

        // Recover_frm.cs

        public string RecoverLbUser = "Username";
        public string RecoverLbCode = "Code";
        public string RecoverBtnSubmit = "Submit";
        public string RecoverBtnCancel = "Cancel";
        public string RecoverBtnResend = "Request Code";
        public string RecoverMsbUsername = "Please enter your username.";
        public string RecoverMsbEmail = "Please enter your email address.";
        public string RecoverMsbCode = "Please enter your code.";
        public string RecoverMsbResendOK = "Request accepted, the email may take some time to arrive.";
        public string RecoverMsbResendFail = "Request failed (wrong Username/Email address).";
        public string RecoverMsbAccept = "An email with the new password has been sent.";
        public string RecoverMsbFailed = "Recovery failed (wrong Username/Email/Code combination).";

        // HubGameList_frm

        public string GameRanked = "Ranked";
        public string GameUnranked = "Unranked";
        public string GameDefaultDeck = "Default Deck";
        public string GameSearch = "Search";
        public string GameFormat = "Format";
        public string GameType = "Game Type";
        public string GameBanList = "Banlist";
        public string GameTimeLimit = "Time Limit";
        public string GameActive = "Active Games";
        public string GameIlligal = "Illegal Games";
        public string GameUserFilter = "User Filter";
        public string GameMinElo = "MinElo";
        public string GameMaxElo = "MaxElo";
        public string GameBtnSearch = "Search";
        public string GameBtnHost = "Host";
        public string GameBtnQuick = "Quick";
        public string GameNotUpdating = "Status: Not Updating";
        public string GameUpdating1 = "Status: Updating for ";
        public string GameUpdating2 = " seconds.";
        public string GameSpectate = "Random Spectate";
        public string GameDuelDevBot = "Duel DevBot";
        public string GameCheckmate = "Checkmate";

        public string GameAll = "All";
        public string GameSingle = "Single";
        public string GameMatch = "Match";
        public string GameTag = "Tag";
        public string GameMinutes = "minutes";

        public string GameNoServers = "No servers are available.";

        public string GamePasswordExsists = "A room with that password already exists.";
        public string GameLocked = "Locked";
        public string GameOpen = "Open";
        public string GameLPChange = "Your quick host settings does not follow the recommend lifepoints rule, do you want to change this to the default?";
        public string GameEnterPassword = "Enter password";
        public string GameWrongPassword = "Incorrect password";

        public string GameMatchCancel = "The Match was canceled, returning to queue. ";
        public string GameJoin = "Join";
        public string GameLeave = "Leave";
        public string GameQuick = "Quick";
        public string GameQueueLabel = "Queue Status: Not Searching";

        public string Ranked = "Ranked";
        public string Unranked = "Unranked";

        // Ranking_frm.cs
        public string RankingSingleGb = "Single Rankings";

        public string RankingMatchGb = "Match Rankings";
        public string RankingRank = "Rank";
        public string RankingUsername = "Username";
        public string RankingElo = "Elo";
        public string RankingWin = "W";
        public string RankingLoss = "L";
        public string RankingDraw = "D";
        public string RankingTeam = "Team";

        public string RankingLoadBtn = "Load rankings";
        public string RankingColor1Btn = "Color1";
        public string RankingColor2Btn = "Color2";

        // Option_frm.cs
        public string optionTitle = "Options";

        public string optionGameTab = "Game Settings";
        public string optionAccountTab = "Account Settings";
        public string optionGb1 = "User Settings";
        public string optionGb2 = "Game Settings";
        public string optionGb3 = "Font Settings";
        public string optionGb4 = "Launcher Settings";
        public string optionGb5 = "Update Password";
        public string optionMsbForget = "Do you really want to forget auto login credentials?";
        public string optionUser = "Default Username";
        public string optionDeck = "Default Deck";
        public string optionBtnAutoLogin = "Forget Auto Login";
        public string optionAntialias = "Antialias";
        public string optionCbSound = "Enable Sound";
        public string optionCbMusic = "Enable Music";
        public string optionCbDirect = "Enable Directx";
        public string optionCbLauncherSound = "Enable Launcher Sound";
        public string optionCbFull = "Fullscreen";
        public string optionTexts = "Font Size";
        public string optionTextf = "Game Font";
        public string optionBtnQuick = "Quick Host Settings";
        public string optionBtnSave = "Save";
        public string optionBtnCancel = "Cancel";
        public string optionCbCustomSkin = "Use Custom Skin";
        public string optionCbAutoPlacing = "Auto Card Placing";
        public string optionCbRandomPlacing = "Random Card Placing";
        public string optionCbAutoChain = "Auto Chain Order";
        public string optionCbNoChainDelay = "No Delay for Chain";
        public string optionCbEnableSleeves = "Enable User Covers";
        public string optionMuteOpp = "Mute Opponents";
        public string optionMuteSpec = "Mute Spectators";
        public string optionSaveReplay = "Save Last Replay";
        public string optionMouseMode = "Mouse Mode";
        public string optionHideSetname = "Hide Setname";
        public string optionChainButtons = "Hide Chain Buttons";
        public string optionOldReplay = "Old Replay Mode";
        public string optionCurrentPW = "Current Password";
        public string optionNewPW = "New Password";
        public string optionConfirmPW = "Confirm Password";
        public string optionEmail = "Email";
        public string optionconfirmEmail = "Confirm Email";
        public string optionUpdatePW = "Update";
        public string ChangeAccept = "Change Accepted";
        public string ChangeFailed = "Change Failed";
        public string optionEmptyMsg = "Must specify current password and new password or new email.";

        // Host_frm.cs
        public string hostGb1 = "Settings";

        public string hostGb2 = "Additional Options";
        public string hostBanlist = "Ban List";
        public string hostTimeLimit = "Time Limit";
        public string hostRules = "Card Rules";
        public string hostMode = "Duel Mode";
        public string hostPrio = "Obsolete Rulings";
        public string hostCheckDeck = "Disable Check Deck";
        public string hostShuffle = "Disable Shuffle Deck";
        public string hostPrerelease = "Enable Prerelease Cards";
        public string hostLifep = "Lifepoints";
        public string hostGameN = "Game Name";
        public string hostBtnHost = "Host";
        public string hostBtnCancel = "Cancel";
        public string hostpassword = "Password";

        // FileManager_frm.cs

        public string fileBtnCopy = "Copy Decklist";
        public string fileBtnRename = "Rename";
        public string fileBtnDelete = "Delete";
        public string fileBtnFolder = "Open Folder";
        public string fileBtnGame = "Open Game";
        public string fileMsgNoExist = "Does not exist";
        public string fileMsgNoSelect = "Nothing selected";
        public string fileMsbMulti = "Can't Rename multiple items";
        public string fileAskDelete = "Are you sure you want to delete the following item(s) ";
        public string fileNewName = "Enter new name";
        public string fileInputConfirm = "Rename";
        public string fileInputCancel = "Cancel";
        public string fileBtnRefresh = "Refresh";
        public string fileBtnImport = "Import";

        // ReplayInfoControl..cs
        public string replayError = "Error opening replay.";

        public string replayType = "Replay Type: ";
        public string replayLP = "Starting Lifepoints: ";
        public string replayHand = "Starting Handcards: ";
        public string replayDraw = "Draw Count: ";

        // About_frm.cs
        public string aboutLabel1 = "About DevPro";

        public string aAboutText = "The YGOPro Online Development Group is a rag tag team of programmers, philanthropist, and generally knowledgeable people in the YGOPro community that seek to better and progress the Yu-Gi-Oh! Online community as a whole by providing services and software to allow duelist to grow by dueling and forming lasting friendships.";
        public string aboutLabel5 = "DevPro Contributors";

        // Customize_frm.cs
        public string cusRemoveBtn = "Remove";

        public string cusAddThemeBtn = "Add";
        public string cusAddContentBtn = "Add";
        public string cusPreview = "Preview";
        public string cusBackup = "Back Up";
        public string cusLabelTheme = "Theme";
        public string cusLabelCont = "Content";

        //Profile_frm.cs
        public string profileName = "Profile";

        public string profileLvl = "Lvl: ";
        public string profileWin = "Wins";
        public string profileLose = "Losses";
        public string profileGb1 = "User Info";
        public string profileGb2 = "Stats";
        public string profileGb3 = "Condition";
        public string profileGb4 = "Ranked";
        public string profileGb5 = "Unranked";
        public string profileTRatio = "W/L Ratio: ";
        public string profileLblLP = "LP Reached 0";
        public string profileLblSurrendered = "Surrendered";
        public string profileLbl0Cards = "0 Cards Left";
        public string profileLblTimeLimit = "Time Limit Up";
        public string profileLblDisconnect = "Rage Quit/D/C";
        public string profileLblExodia = "Exodia";
        public string profileLblFinalCountdown = "Final Countdown";
        public string profileLblVennominaga = "Vennominaga";
        public string profileLblHorakhty = "Horakhty";
        public string profileLblExodius = "Exodius";
        public string profileLblDestinyBoard = "Destiny Board";
        public string profileLblLastTurn = "Last Turn";
        public string profileLblDestinyLeo = "Destiny Leo";
        public string profileLblUnknown = "Unknown";
        public string profileLblUsername = "Username: ";
        public string profileLblSecret = "Profile Key: ";
        public string profileLblwld = "Wins/Losses/Draws";
        public string profileLblTRank = "Rank: ";
        public string profileLblRank = "Rank (Match): ";
        public string profileLblSingleRank = "Rank (Single): ";
        public string profileLblTeam = "Team: ";
        public string profileLblElo = "Elo (Match): ";
        public string profileLblSingleElo = "Elo (Single): ";

        //ChatOptions_frm.cs

        public string chatoptionsFormName = "Chat Options";
        public string chatoptionsGb1 = "Chat Settings";
        public string chatoptionsGb2 = "Other Settings";
        public string chatoptionsGb3 = "Color Style";
        public string chatoptionsGb4 = "Channel Settings";
        public string chatoptionsLblHideJoinLeave = "Hide Join/Leave";
        public string chatoptionsLblPmWindows = "PM Windows";
        public string chatoptionsLblUserColors = "Username Colors";
        public string chatoptionsLblRefuseTeamInvites = "Refuse Team Invites";
        public string chatoptionsLblColorBlindMode = "Color Blind Mode";
        public string chatoptionsLblShowTimeStamp = "Show Time Stamp";
        public string chatoptionsLblRefuseDuelRequests = "Refuse Duel Requests";

        public string chatoptionsFontTitle = "Font Settings";
        public string chatoptionsFontLbl = "Font";
        public string chatoptionsFontSize = "Font Size";

        public string chatoptionsLblChatBackground = "Chat Background";
        public string chatoptionsLblNormalText = "Normal Text";
        public string chatoptionsLblLevel98 = "Bot";
        public string chatoptionsLblLevel2 = "TD";
        public string chatoptionsLblLevel1 = "Helper";
        public string chatoptionsLblNormalUser = "Normal Username";
        public string chatoptionsLblServerMessages = "Server Message";
        public string chatoptionsLblMeMessage = "/Me Message";
        public string chatoptionsLblJoin = "Join";
        public string chatoptionsLblLeave = "Leave";
        public string chatoptionsLblSystem = "System";
        public string chatoptionsBtnRequestSettings = "Request Settings";
        public string chatoptionsBtnSave = "Save";
        public string chatoptionsBtnCancel = "Cancel";
        public string chatoptionsRequestFormText = "Duel Request Settings";

        //Chat_frm.cs

        public string chatTitle = "Chat";
        public string chatMsg1 = "Welcome to the DevPro chat system!";
        public string chatMsg2 = "To join a channel please click the channel list button.";
        public string chatBtnoptions = "Settings";
        public string chatBtnUser = "Search Users";
        public string chatBtnAdmin = "Search Admins";
        public string chatBtnTeam = "Search in Team";
        public string chatBtnFriend = "Search in Friendlist";
        public string chatBtnChannel = "Channel List";
        public string chatBtnLeave = "Leave Channel";
        public string chatTabUsers = "Users";
        public string chatTabFriends = "Friends";
        public string chatTabIgnore = "Ignore";
        public string chatKick = "Kick";
        public string chatMute = "Local Mute";
        public string chatBan = "Ban";
        public string chatTeamRemove = "Remove from Team";
        public string chatUserCount = "User Count: ";
        public string chatAddFriend = "Add to Friends";
        public string chatRequestDuel = "Request Duel";
        public string chatIgnoreUser = "Ignore User";
        public string chatViewProfile = "View Profile";
        public string chatRemoveFriend = "Remove Friend";
        public string chatRemoveIgnore = "Remove";
        public string chatAutoScroll = "Auto-Scroll";
        public string chatSpectate = "Spectate";

        public string chatUserTab = "Users";
        public string chatIgnoreTab = "Ignore";
        public string chatOptionTab = "Options";
        public string chatChannelTab = "Channel";
        public string chatUserListTab = "UserList";

        // Ban_frm.cs

        public string banTitle = "Ban User";
        public string banMessageLbl = "Please fill out the form";
        public string banTimeLbl = "Time to ban (in hours)";
        public string banReasonLbl = "Reason for ban";
        public string banConfirm = "Confirm";
        public string banCancel = "Cancel";

        public string kickTitle = "Kick User";
        public string kickMessageLbl = "Please fill out the form";
        public string kickReasonLbl = "Reason for kick";
        public string kickConfirm = "Confirm";
        public string kickCancel = "Cancel";

        public string muteTitle = "Mute User";
        public string muteMessageLbl = "Please fill out the form";
        public string muteTimeLbl = "Time to mute (in hours)";
        public string muteReasonLbl = "Reason for mute";
        public string muteConfirm = "Confirm";
        public string muteCancel = "Cancel";

        // ChannelList_frm.cs

        public string channelCreate = "Create";
        public string channelJoin = "Join";
        public string channelDefault = "Default";
        public string channelTitle = "Create Channel";
        public string channelMsg = "Enter Channel Name";
        public string channelCancel = "Cancel";
        // Main_frm.cs

        public string MainFormTitle = "YGOPro Launcher ";
        public string MainGameTab = "Game List";
        public string MainChatTab = "Chat";
        public string MainRankingTab = "Ranking";
        public string MainTornyTab = "Tournament Room";
        public string MainYoutubeTab = "Youtube";
        public string MainFileManagerTab = "File Manager";
        public string MainFileDeckTab = "Decks";
        public string MainFileReplayTab = "Replays";
        public string MainCustomizeTab = "Customize";
        public string MainAboutTab = "About";

        public string MainForumBtn = "Discord";
        public string MainSiteBtn = "Forum";
        public string MainDeckBtn = "Deck Edit";
        public string MainReplaysBtn = "Replays";
        public string MainOfflineBtn = "Offline";
        public string MainProfileBtn = "Profile";
        public string MainServerMessage = "Launcher messages will spawn here.";

        //DuelRequest_frm
        public string DuelReqestMessage = " has challenged you to an unranked duel! Do you accept?";

        public string DuelRequestBanlist = " Banlist: ";
        public string DuelRequestRules = " Rules: ";
        public string DuelRequestMode = " Type: ";

        //DevPro SupportTab
        public string SupportTitle = "Support DevPro";

        public string SupportItem1Name = "Donator Status";
        public string SupportItem1Des = "Unlocks Donator status in chat, Orange username and additional chat commands.";
        public string SupportItem2Name = "Change Username";
        public string SupportItem2Des = "Change your account name while retaining all your ranked stats.";
        public string SupportItem3Name = "Reset Ranking Stats";
        public string SupportItem3Des = "Reset your ranking stats.";
        public string SupportItem4Name = "Unban User";
        public string SupportItem4Des = "Unban a user who was banned.";
        public string SupportItem5Name = "Custom Username Color";
        public string SupportItem5Des = "Change the color of your username in chat.";
        public string SupportItem6Name = "Create Team";
        public string SupportItem6Des = "Create a team.";
        public string SupportItem7Name = "Send Server Message";
        public string SupportItem7Des = "Send a server message to everyone.(Limited: 3 Messages per day)";
        public string SupportItem8Name = "Custom Sleeves";
        public string SupportItem8Des = "Upload a custom sleeve that all users will be able to see in duels.";
        public string SupportUserTagName = "User Tag";
        public string SupportUserTagDes = "Add a custom user Tag to your name for one month.";

        public string SupportBalance = "Balance";
        public string Supportgb2 = "Support DevPro";
        public string SupportLbl = "All donations are used to pay the server costs. (Opens in your web browser.)";

        public string SupportRenameInput = "Enter New Username";
        public string SupportUnbanInput = "Enter Username";
        public string SupportTeamNameInput = "Enter Team Name";
        public string SupportMSGInput = "Enter Message";
        public string SupportTagInput = "Enter New Tag";

        public string SupportRefreshBtn = "Refresh";
        public string SupportTransferBtn = "Transfer";
        public string SupportGetBtn = "Get";
    }
}