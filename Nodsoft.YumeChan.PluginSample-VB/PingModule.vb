Imports Discord.Commands


' Classes can here act as a bundle of Commands. The only limitation is one Class per Group Name.
'
' A few Rules :
'   - Class MUST inherit ModuleBase to get flagged as a Module containing commands.
'   - Class MUST be set as public to get picked up by the Loader.
'
' /!\ DO NOT USE THESE CLASSES TO STORE PERSISTENT DATA. /!\
' Each "Command Group" Class is Instantiated when a Command from its group is called. 
' The instance immediately vanishes after finishing command execution.
<Group("ping")>
Public Class PingModule
    Inherits ModuleBase(Of SocketCommandContext)

    <Command("visualbasic"), [Alias]("vb")>
    Public Async Function PingHelloVisualBasicCommandAsync() As Task
        Await ReplyAsync("Hello from YumeChan's Visual Basic Sample Plugin !")
    End Function

End Class
