// CS1961: The contravariant type parameter `T' must be invariantly valid on `B<T>'
// Line: 8

interface A<T>
{
}

interface B<in T> : A<T>
{
}
