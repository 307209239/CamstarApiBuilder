// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IWCFService
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using Camstar.WCF.ObjectStack;

namespace Camstar.WCF.Services
{
  public interface IWCFService
  {
    ResultStatus BeginTransaction();

    ResultStatus RollBackTransaction();

    ResultStatus CommitTransaction();

    ResultStatus CommitTransaction(Request request, out Result result);

    ResultStatus GetEnvironment(Request request, out Result result);

    ResultStatus GetEnvironment(DCObject cdo, Request request, out Result result);

    ResultStatus AddDataTransaction(DCObject cdo);

    ResultStatus ExecuteTransaction();

    ResultStatus ExecuteTransaction(Request request, out Result result);

    ResultStatus ExecuteTransaction(DCObject cdo);

    ResultStatus ExecuteTransaction(DCObject cdo, Request request, out Result result);
  }
}
