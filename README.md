# Repository for reproducing problem with LibGit2Sharp

```
$ sh ./build.sh --verbosity="diagnostic"
```

## Received result on MacOS

```sh
An error occurred when executing task 'Default'.
Error: System.AggregateException: One or more errors occurred. ---> System.TypeInitializationException: The type initializer for 'LibGit2Sharp.Core.NativeMethods' threw an exception. ---> System.DllNotFoundException: git2-8e0b172
  at (wrapper managed-to-native) LibGit2Sharp.Core.NativeMethods.git_libgit2_init()
  at LibGit2Sharp.Core.NativeMethods.LoadNativeLibrary () [0x00000] in <a5c78e07c86342908d97a25953f7a193>:0
  at LibGit2Sharp.Core.NativeMethods..cctor () [0x00045] in <a5c78e07c86342908d97a25953f7a193>:0
   --- End of inner exception stack trace ---
  at LibGit2Sharp.Core.Proxy.git_repository_open (System.String path) [0x00008] in <a5c78e07c86342908d97a25953f7a193>:0
  at LibGit2Sharp.Repository..ctor (System.String path, LibGit2Sharp.RepositoryOptions options, LibGit2Sharp.Repository+RepositoryRequiredParameterrequiredParameter) [0x002ee] in <a5c78e07c86342908d97a25953f7a193>:0
  at LibGit2Sharp.Repository..ctor (System.String path) [0x00000] in <a5c78e07c86342908d97a25953f7a193>:0
  at Submission#0.<<Initialize>>b__0_0 () [0x0000d] in <f803bad536764e85a6be0428363b1aa0>:0
  at Cake.Core.CakeTaskBuilderExtensions+<>c__DisplayClass17_0.<Does>b__0 (Cake.Core.ICakeContext context) [0x00000] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
  at Cake.Core.CakeTaskBuilderExtensions+<>c__DisplayClass20_0.<Does>b__0 (Cake.Core.ICakeContext x) [0x00000] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
  at Cake.Core.CakeTask+<Execute>d__43.MoveNext () [0x00066] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable+ConfiguredTaskAwaiter.GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Cake.Core.DefaultExecutionStrategy+<ExecuteAsync>d__4.MoveNext () [0x000ee] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable+ConfiguredTaskAwaiter.GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Cake.Core.CakeEngine+<ExecuteTaskAsync>d__31.MoveNext () [0x00131] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable+ConfiguredTaskAwaiter.GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Cake.Core.CakeEngine+<RunTask>d__28.MoveNext () [0x00124] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Cake.Core.CakeEngine+<RunTargetAsync>d__27.MoveNext () [0x00338] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[TResult].GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Cake.Scripting.BuildScriptHost+<RunTargetAsync>d__3.MoveNext () [0x0009f] in <52bc22bce5254240ba373b3cf23da1ab>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter`1[TResult].GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Cake.Core.Scripting.ScriptHost.RunTarget (System.String target) [0x0000d] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
  at Submission#0+<<Initialize>>d__0.MoveNext () [0x00053] in <f803bad536764e85a6be0428363b1aa0>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[TResult].GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Microsoft.CodeAnalysis.Scripting.ScriptExecutionState+<RunSubmissionsAsync>d__9`1[TResult].MoveNext () [0x00186] in <3ee4bd870c1146d59b98317e4bbdcbe8>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[TResult].GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Microsoft.CodeAnalysis.Scripting.Script`1+<RunSubmissionsAsync>d__21[T].MoveNext () [0x000a8] in <3ee4bd870c1146d59b98317e4bbdcbe8>:0
   --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.ThrowIfExceptional (System.Boolean includeTaskCanceledExceptions) [0x00011] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Threading.Tasks.Task.Wait (System.Int32 millisecondsTimeout, System.Threading.CancellationToken cancellationToken) [0x00043] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Threading.Tasks.Task.Wait () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Cake.Scripting.Roslyn.RoslynScriptSession.Execute (Cake.Core.Scripting.Script script) [0x001a7] in <52bc22bce5254240ba373b3cf23da1ab>:0
  at Cake.Core.Scripting.ScriptRunner.Run (Cake.Core.Scripting.IScriptHost host, Cake.Core.IO.FilePath scriptPath, System.Collections.Generic.IDictionary`2[TKey,TValue] arguments) [0x00358] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
  at Cake.Commands.BuildCommand.Execute (Cake.CakeOptions options) [0x0003f] in <52bc22bce5254240ba373b3cf23da1ab>:0
  at Cake.CakeApplication.Run (Cake.CakeOptions options) [0x00015] in <52bc22bce5254240ba373b3cf23da1ab>:0
  at Cake.Program.Main () [0x000d1] in <52bc22bce5254240ba373b3cf23da1ab>:0
---> (Inner Exception #0) System.TypeInitializationException: The type initializer for 'LibGit2Sharp.Core.NativeMethods' threw an exception. ---> System.DllNotFoundException: git2-8e0b172
  at (wrapper managed-to-native) LibGit2Sharp.Core.NativeMethods.git_libgit2_init()
  at LibGit2Sharp.Core.NativeMethods.LoadNativeLibrary () [0x00000] in <a5c78e07c86342908d97a25953f7a193>:0
  at LibGit2Sharp.Core.NativeMethods..cctor () [0x00045] in <a5c78e07c86342908d97a25953f7a193>:0
   --- End of inner exception stack trace ---
  at LibGit2Sharp.Core.Proxy.git_repository_open (System.String path) [0x00008] in <a5c78e07c86342908d97a25953f7a193>:0
  at LibGit2Sharp.Repository..ctor (System.String path, LibGit2Sharp.RepositoryOptions options, LibGit2Sharp.Repository+RepositoryRequiredParameterrequiredParameter) [0x002ee] in <a5c78e07c86342908d97a25953f7a193>:0
  at LibGit2Sharp.Repository..ctor (System.String path) [0x00000] in <a5c78e07c86342908d97a25953f7a193>:0
  at Submission#0.<<Initialize>>b__0_0 () [0x0000d] in <f803bad536764e85a6be0428363b1aa0>:0
  at Cake.Core.CakeTaskBuilderExtensions+<>c__DisplayClass17_0.<Does>b__0 (Cake.Core.ICakeContext context) [0x00000] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
  at Cake.Core.CakeTaskBuilderExtensions+<>c__DisplayClass20_0.<Does>b__0 (Cake.Core.ICakeContext x) [0x00000] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
  at Cake.Core.CakeTask+<Execute>d__43.MoveNext () [0x00066] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable+ConfiguredTaskAwaiter.GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Cake.Core.DefaultExecutionStrategy+<ExecuteAsync>d__4.MoveNext () [0x000ee] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable+ConfiguredTaskAwaiter.GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Cake.Core.CakeEngine+<ExecuteTaskAsync>d__31.MoveNext () [0x00131] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable+ConfiguredTaskAwaiter.GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Cake.Core.CakeEngine+<RunTask>d__28.MoveNext () [0x00124] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Cake.Core.CakeEngine+<RunTargetAsync>d__27.MoveNext () [0x00338] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[TResult].GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Cake.Scripting.BuildScriptHost+<RunTargetAsync>d__3.MoveNext () [0x0009f] in <52bc22bce5254240ba373b3cf23da1ab>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter`1[TResult].GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Cake.Core.Scripting.ScriptHost.RunTarget (System.String target) [0x0000d] in <1a12afcf649f4de8ab5d15d82d4f6310>:0
  at Submission#0+<<Initialize>>d__0.MoveNext () [0x00053] in <f803bad536764e85a6be0428363b1aa0>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[TResult].GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Microsoft.CodeAnalysis.Scripting.ScriptExecutionState+<RunSubmissionsAsync>d__9`1[TResult].MoveNext () [0x00186] in <3ee4bd870c1146d59b98317e4bbdcbe8>:0
--- End of stack trace from previous location where exception was thrown ---
  at System.Runtime.ExceptionServices.ExceptionDispatchInfo.Throw () [0x0000c] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess (System.Threading.Tasks.Task task) [0x0003e] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification (System.Threading.Tasks.Task task) [0x00028] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.TaskAwaiter.ValidateEnd (System.Threading.Tasks.Task task) [0x00008] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[TResult].GetResult () [0x00000] in <bb7b695b8c6246b3ac1646577aea7650>:0
  at Microsoft.CodeAnalysis.Scripting.Script`1+<RunSubmissionsAsync>d__21[T].MoveNext () [0x000a8] in <3ee4bd870c1146d59b98317e4bbdcbe8>:0 <---
```
