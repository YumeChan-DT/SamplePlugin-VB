Imports Nodsoft.YumeChan.PluginBase


' This Class defines the Plugin, and makes it visible to the Loader.
Public Class PluginManifest     ' Class MUST be set as Public to get picked up by the Loader.
    Implements IPlugin

    ' For Good principle, do not change a thing here, unless your Versionning has to be different from that of the Assembly.
    ' Consider changing your Version within the Assembly instead.
    Public ReadOnly Property PluginVersion As Version Implements IPlugin.PluginVersion
        Get
            Return [GetType].Assembly.GetName.Version
        End Get
    End Property

    Public ReadOnly Property PluginDisplayName As String Implements IPlugin.PluginDisplayName
        Get
            Return "YumeChan : Sample Plugin"
        End Get
    End Property

    Public ReadOnly Property PluginStealth As Boolean Implements IPlugin.PluginStealth
        Get
            Return False
        End Get
    End Property

    ' This is handled solely by the LoadPlugin() and UnloadPlugin() Functions below.
    Public Property PluginLoaded As Boolean Implements IPlugin.PluginLoaded
        Get
            Return _PluginLoaded
        End Get
        Private Set
            _PluginLoaded = Value
        End Set
    End Property
    Private _PluginLoaded As Boolean

    Public Function LoadPlugin() As Task Implements IPlugin.LoadPlugin
        ' Here goes the Loading Logic, if some loading procedure is needed. Treat it as a Ctor.

        PluginLoaded = True
        Return Task.CompletedTask
    End Function

    Public Function UnloadPlugin() As Task Implements IPlugin.UnloadPlugin
        ' Here goes the Unloading Logic, if some unloading (e.g: Disposal) is needed. Treat it as a Dtor.

        PluginLoaded = False
        Return Task.CompletedTask
    End Function
End Class

' For more info, check Discord.NET's guide on Commands : https://discord.foxbot.me/docs/guides/commands/intro.html#modules
' A good knowledge of C# and CLR Aspects will be necessary, to translate Examples from C# to VB.