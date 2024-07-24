//Command is a behavioral design pattern that turns a request into a stand-alone object
//    that contains all information about the request. This transformation lets you pass 
//    requests as a method arguments, delay or queue a request’s execution, and support undoable operations.

//TV tv = new TV();
//Stereo stereo = new Stereo();

//// Create command objects
//ICommand turnOnTVCommand = new TurnOnCommand(tv);
//ICommand turnOffTVCommand = new TurnOffCommand(tv);
//ICommand adjustVolumeStereoCommand = new AdjustVolumeCommand(stereo);
//ICommand changeChannelTVCommand = new ChangeChannelCommand(tv);

//// Create remote control
//RemoteControl remote = new RemoteControl();

//// Set and execute commands
//remote.setCommand(turnOnTVCommand);
//remote.pressButton(); // Outputs: TV is now on

//remote.setCommand(adjustVolumeStereoCommand);
//remote.pressButton(); // Outputs: Volume adjusted

//remote.setCommand(changeChannelTVCommand);
//remote.pressButton(); // Outputs: Channel changed

//remote.setCommand(turnOffTVCommand);
//remote.pressButton(); // Outputs: TV is now off


class RemoteControl
{
    private ICommand command;

    public void setCommand(ICommand command)
    {
        this.command = command;
    }

    public void pressButton()
    {
        command.execute();
    }
}
public interface ICommand
{
    void execute();
}

public class TurnOnCommand : ICommand
{
    private IDevice device;

    public TurnOnCommand(IDevice device)
    {
        this.device = device;
    }

    public void execute()
    {
        device.turnOn();
    }
}

// Concrete command for turning a device off
public class TurnOffCommand : ICommand
{
    private IDevice device;

    public TurnOffCommand(IDevice device)
    {
        this.device = device;
    }

    public void execute()
    {
        device.turnOff();
    }
}

// Concrete command for adjusting the volume of a stereo
public class AdjustVolumeCommand : ICommand
{
    private Stereo stereo;

    public AdjustVolumeCommand(Stereo stereo)
    {
        this.stereo = stereo;
    }
    public void execute()
    {
        stereo.adjustVolume();
    }
}

// Concrete command for changing the channel of a TV
public class ChangeChannelCommand : ICommand
{
    private TV tv;

    public ChangeChannelCommand(TV tv)
    {
        this.tv = tv;
    }

    public void execute()
    {
        tv.changeChannel();
    }
}