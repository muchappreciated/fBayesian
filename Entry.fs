module Entry

open Tokeniser

type IEntry =
    abstract Tokens : string []
    abstract IsSpam : bool option

type Entry (text: string, isSpam: bool option) =
    interface IEntry with
        member __.IsSpam = isSpam
        member __.Tokens = Tokenise text