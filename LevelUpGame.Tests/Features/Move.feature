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
        | 5 | 5 | SOUTH | 32 | 6 | 5 | 33 |
        | 9 | 9 | SOUTH | 55 | 9 | 9 | 56 |
        | 0 | 0 | SOUTH | 34 | 1 | 0 | 35 |
        | 9 | 0 | SOUTH | 44 | 9 | 0 | 45 |
        | 5 | 5 | NORTH | 3  | 4 | 5 | 4  |
        | 0 | 0 | NORTH | 8  | 0 | 0 | 9  |
        | 9 | 9 | NORTH | 7  | 8 | 9 | 8  |
        | 5 | 9 | NORTH | 76 | 4 | 9 | 78 |
        | 5 | 5 | EAST  | 0  | 5 | 6 | 1  |
        | 0 | 0 | EAST  | 54 | 0 | 1 | 55 |
        | 9 | 9 | EAST  | 17 | 9 | 9 | 18 |
        | 5 | 9 | EAST  | 20 | 5 | 9 | 21 |
        | 5 | 5 | WEST  | 11 | 5 | 4 | 12 |
        | 0 | 0 | WEST  | 101 | 0 | 0 | 102 |
        | 9 | 9 | WEST  | 61 | 9 | 8 | 62 |
        | 9 | 0 | WEST  | 88 | 9 | 0 | 89 |