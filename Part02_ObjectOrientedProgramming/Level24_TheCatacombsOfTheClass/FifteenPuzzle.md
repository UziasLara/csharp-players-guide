**Does this design need to change to allow for different size boards?**

> The design itself shouldn't need to change. Different logic may be needed but as long as it is built with modularity in mind, it should be doable. After all, software is *soft*.

>|  Game Manager    |   Helper Classes      |
>|  ---             |    ---                |
>|  Track Stats     |   **Fifteen Puzzle**  |
>|  Display Results |                       |  

---

>|  FifteenPuzzle   |   Helper Classes      |
>|  ---             |    ---                |
>|  Track Game      |   **Board**           |
>|                  |   **Player**          |

---

>|  Renderer        |   Helper Classes      |
>|  ---             |   ---                 |
>|  Display Board   |   **Board**           |

---

>|  Board           |                       |
>|  ---             |   ---                 |
>|  Creates Board   |                       |
>|  Updates Board   |                       |

---

>|   Player         |                       |
>|   ---            |   ---                 |
>|   Get Direction  |                       |

---
