Feature: Move
    I want to move my character. If they attempt to move past a boundary, the move results in no change in position but does increment move count.

@acceptance
Scenario Outline: Move in a direction
    Simple example of how to test move

    Given the character starts at position with XCoordinates <startingPositionX>
    And starts at YCoordinates <startingPositionY>
    And the player chooses to move in <direction>
    And the current move count is <startingMoveCount>
    When the character moves
    Then the character is now at position with XCoordinates <endingPositionX>
    And YCoordinates  <endingPositionY>
    And the new move count is <endingMoveCount>
    Examples:

        | startingPositionX | startingPositionY | direction | startingMoveCount | endingPositionX | endingPositionY | endingMoveCount |
        | 8                 | 8                 | EAST     | 10                | 8               | 9               | 11              |
        | 0 | 0 | EAST | 32 | 0 | 1 | 33 |
        | 5 | 5 | EAST  | 55 | 5 | 6 | 56 |
        | 9 | 9 | EAST  | 78 | 9 | 9 | 79 |