# dutil
[![Build status](https://ci.appveyor.com/api/projects/status/5b18yymh85j0v81a?svg=true)](https://ci.appveyor.com/project/dluciano/dutil)

A library containing a IEntity, a state machine and other artefacts used generally 
- IEntity:
Use it to extends your Entities clases. It contains a common int Id property. Probably this class will be moved to A dutil.Entites classes later.

## State Machine
### How to use it
- StateTransition: use this class to create a finite state machine.
To use it, you will need: 
1. Create an Enum with the states and an Enum with the Transitions. (It can be any other type of object but I recommend to use an Enum or const string implemented in a static class)
2. Implement the class ITransitable<TState> in the object that will have the states.
3. Register the transition using StateTransition<TState, TTransitions>().AddTrasition(from, to, transition)... Replace from and to with the State
4. Use the state machine to change the state of your ITransitable object.
  
### Example
```c#
// 1. Register states and transitions
public enum GameState : byte
    {
        NONE,
        PLAYING,
        FINISHED,
        ABORTED
    }
    public enum GameSessionTransitions : byte
    {
        START_GAME,
        FINISH_GAME,
        ABORT_GAME
    }

// 2. Register
public class Game : IEntity, ITransitable<GameState>{
   public GameState CurrentState { get; set; } = GameState.NONE;
}

// 3. Register the transitions
var sMachine = new StateMachine<GameState, GameSessionTransitions>()
                    .AddTransition(GameState.NONE, GameState.PLAYING, GameSessionTransitions.START_GAME)
                    .AddTransition(GameState.PLAYING, GameState.FINISHED, GameSessionTransitions.FINISH_GAME)
                    .AddTransition(GameState.PLAYING, GameState.ABORTED, GameSessionTransitions.ABORT_GAME))

// 4. Use your state machine
var game = new Game();
sMachine.ChangeState(game.GameData, GameSessionTransitions.START_GAME);
Console.WriteLine(game.CurrentState);
```
### Detailed information

The state machine store a HashSet of TTransition objects and a  Dictionary<TFrom, TTo>. When you register a transition this will be unique and will execute an action that change the state from m1 to m2. A transition from m1 to m2 is unique

## IListRandomizer
Use this interface and its implementation to ordeer a list randomly

## IEntity
Use this interface to extend entities classes and have a int Id property in all of them
