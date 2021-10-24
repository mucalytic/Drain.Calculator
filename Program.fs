open System

type DrainType = Ransack | Deprive

type Drain =
  { Name: string
    Amount: int
    Requirements: int
    Type: DrainType }

type Ladder =
  { Ransacks: Drain list
    Deprives: Drain list }

let drains =
  [|
    { Name = "Ransack (Weak)";
      Amount = 9;
      Requirements = 58;
      Type = Ransack; }
    { Name = "Ransack (Minor)";
      Amount = 16;
      Requirements = 99;
      Type = Ransack; }
    { Name = "Ransack (Average)";
      Amount = 25;
      Requirements = 149;
      Type = Ransack; }
    { Name = "Ransack (Lesser)";
      Amount = 34;
      Requirements = 191;
      Type = Ransack; }
    { Name = "Ransack";
      Amount = 47;
      Requirements = 241;
      Type = Ransack; }
    { Name = "Ransack (Major)";
      Amount = 63;
      Requirements = 324;
      Type = Ransack; }
    { Name = "Ransack (Advanced)";
      Amount = 79;
      Requirements = 402;
      Type = Ransack; }
    { Name = "Plunder (Weak)";
      Amount = 97;
      Requirements = 474;
      Type = Ransack; }
    { Name = "Plunder (Minor)";
      Amount = 115;
      Requirements = 572;
      Type = Ransack; }
    { Name = "Plunder (Average)";
      Amount = 132;
      Requirements = 669;
      Type = Ransack; }
    { Name = "Plunder (Lesser)";
      Amount = 143;
      Requirements = 711;
      Type = Ransack; }
    { Name = "Plunder";
      Amount = 151;
      Requirements = 745;
      Type = Ransack; }
    { Name = "Plunder (Major)";
      Amount = 163;
      Requirements = 795;
      Type = Ransack; }
    { Name = "Plunder (Advanced)";
      Amount = 178;
      Requirements = 853;
      Type = Ransack; }
    { Name = "Plunder (Nanite Enhanced)";
      Amount = 210;
      Requirements = 1001;
      Type = Ransack; }
    { Name = "Plunder (Nanite Improved)";
      Amount = 275;
      Requirements = 1801;
      Type = Deprive; }
    { Name = "Deprive (Weak)";
      Amount = 5;
      Requirements = 36;
      Type = Deprive; }
    { Name = "Deprive (Minor)";
      Amount = 13;
      Requirements = 79;
      Type = Deprive; }
    { Name = "Deprive (Average)";
      Amount = 21;
      Requirements = 123;
      Type = Deprive; }
    { Name = "Deprive (Lesser)";
      Amount = 29;
      Requirements = 171;
      Type = Deprive; }
    { Name = "Deprive";
      Amount = 40;
      Requirements = 216;
      Type = Deprive; }
    { Name = "Deprive (Major)";
      Amount = 55;
      Requirements = 278;
      Type = Deprive; }
    { Name = "Deprive (Advanced)";
      Amount = 72;
      Requirements = 371;
      Type = Deprive; }
    { Name = "Divest (Weak)";
      Amount = 88;
      Requirements = 435;
      Type = Deprive; }
    { Name = "Divest (Minor)";
      Amount = 106;
      Requirements = 526;
      Type = Deprive; }
    { Name = "Divest (Average)";
      Amount = 124;
      Requirements = 621;
      Type = Deprive; }
    { Name = "Divest (Lesser)";
      Amount = 137;
      Requirements = 694;
      Type = Deprive; }
    { Name = "Divest";
      Amount = 146;
      Requirements = 728;
      Type = Deprive; }
    { Name = "Divest (Major)";
      Amount = 157;
      Requirements = 769;
      Type = Deprive; }
    { Name = "Divest (Advanced)";
      Amount = 170;
      Requirements = 827;
      Type = Deprive; }
    { Name = "Divest (Nanite Enhanced)";
      Amount = 210;
      Requirements = 1001;
      Type = Deprive; }
    { Name = "Divest (Nanite Improved)";
      Amount = 275;
      Requirements = 1801;
      Type = Deprive; }
  |]

let ladder = { Ransacks = []
               Deprives = [] }

// Drains require PM and TS
// 1. create a tuple of stacks
// 2. find the highest wrangle that we can cast - calc is original pm and ts plus the top item on each stack
// 3. if that type of wrangle is already the top item in the stack for that type, print the two stacks and the final pm and ts
//    if that type of wrangle is not the top item in the stack for that type, add the wrangle to the stack for its type
// 4. go to 2

let toInt (s: string) =
  try s |> int |> Some
  with :? FormatException -> None

let argsToInts (ss: string[]) =
  ss |> Array.map toInt |> Array.choose id

// try writing it in C# first

[<EntryPoint>]
let main argv =
  let attributes = argsToInts argv
  match Array.length attributes with
  | 6 -> printf $"%A{attributes}\n"
  | _ -> printf "must have six arguments: mm bm pm si ts mc\n"  
  0

