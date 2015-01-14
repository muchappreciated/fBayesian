namespace Classifier

open Entry
open Analyser

(* Given an Entry classify spam / not spam *)
type Classify() = 
    
    let Tolerance = 0.05

    let CalcProbability (token:string, spamCount, notSpamCount) =
        ""

    let Prediction (item:IEntry, spam:IEntry[], notSpam:IEntry[]) =
        let spamCount = spam.Length // dont think this is right
        let notSpamCount = notSpam.Length // Should check 
        
        item.Tokens
        |> Array.map (fun token -> CalcProbability(token, spamCount, notSpamCount))

    // The indirection is so we can catergorise floats to some other type later (eg. spam/not spam)
    let Catergorise (item:Entry, spam:IEntry[], notspam:IEntry[]) = 
        Prediction (item, spam, notspam)

    let classify (entry:Entry) = 0.5
    
    member this.Classify = classify
