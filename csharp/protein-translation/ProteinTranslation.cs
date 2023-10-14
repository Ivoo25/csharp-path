using System;
using System.Collections.Generic;
using System.Linq;
public static class ProteinTranslation
{
    public static string[] Proteins(string strand) =>
        strand.Chunked(3).Select(ToProtein).TakeWhile(protein => protein != "STOP").ToArray();
    /*Chunked is an extension method that splits a string into chunks of a given size
     *Select is a LINQ method that transforms each element of a collection, in this case each chunk of the strand into a protein,
     *for example: "AUG" -> "Methionine"
     *TakeWhile is a LINQ method that takes elements from a collection while a condition is true, in this case while the protein
     *is not "STOP"
     *ToArray is a LINQ method that converts the collection into an array
     */
    private static string ToProtein(string input) =>
        input switch
        {
            "AUG" => "Methionine",
            "UUU" => "Phenylalanine",
            "UUC" => "Phenylalanine",
            "UUA" => "Leucine",
            "UUG" => "Leucine",
            "UCU" => "Serine",
            "UCC" => "Serine",
            "UCA" => "Serine",
            "UCG" => "Serine",
            "UAU" => "Tyrosine",
            "UAC" => "Tyrosine",
            "UGU" => "Cysteine",
            "UGC" => "Cysteine",
            "UGG" => "Tryptophan",
            "UAA" => "STOP",
            "UAG" => "STOP",
            "UGA" => "STOP",
            _ => throw new Exception("Invalid sequence")
        };

    private static IEnumerable<string> Chunked(this string input, int size)
    {
        for (var i = 0; i < input.Length; i += size)
            yield return input[i..(i + size)];
    } //This is an extension method that splits a string into chunks of a given size
}