// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangeProcessBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  public interface IChangeProcessBase : IProcessObjectTxnBase
  {
    [OperationContract]
    ResultStatus Delete(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus Delete(DCObject changeProcess, Request request, out Result result);

    [OperationContract]
    ResultStatus Delete(DCObject changeProcess);

    [OperationContract]
    ResultStatus Delete();

    [OperationContract]
    ResultStatus GetOrganization(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus GetOrganization(
      DCObject changeProcess,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus GetOrganization(DCObject changeProcess);

    [OperationContract]
    ResultStatus GetOrganization();

    [OperationContract]
    ResultStatus New(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus New(DCObject changeProcess, Request request, out Result result);

    [OperationContract]
    ResultStatus New(DCObject changeProcess);

    [OperationContract]
    ResultStatus New();
  }
}
