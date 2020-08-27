// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMaintenanceBase
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  public interface IMaintenanceBase : IUpdateBase
  {
    [OperationContract]
    ResultStatus Delete(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus Delete(DCObject maintenance, Request request, out Result result);

    [OperationContract]
    ResultStatus Delete(DCObject maintenance);

    [OperationContract]
    ResultStatus Delete();

    [OperationContract]
    ResultStatus Freeze(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus Freeze(DCObject maintenance, Request request, out Result result);

    [OperationContract]
    ResultStatus Freeze(DCObject maintenance);

    [OperationContract]
    ResultStatus Freeze();

    [OperationContract]
    ResultStatus LoadESigDetails(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      DCObject maintenance,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(DCObject maintenance);

    [OperationContract]
    ResultStatus LoadESigDetails();

    [OperationContract]
    ResultStatus New(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus New(DCObject maintenance, Request request, out Result result);

    [OperationContract]
    ResultStatus New(DCObject maintenance);

    [OperationContract]
    ResultStatus New();

    [OperationContract]
    ResultStatus NewCopy(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus NewCopy(DCObject maintenance, Request request, out Result result);

    [OperationContract]
    ResultStatus NewCopy(DCObject maintenance);

    [OperationContract]
    ResultStatus NewCopy();

    [OperationContract]
    ResultStatus SaveAs(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus SaveAs(DCObject maintenance, Request request, out Result result);

    [OperationContract]
    ResultStatus SaveAs(DCObject maintenance);

    [OperationContract]
    ResultStatus SaveAs();

    [OperationContract]
    ResultStatus UnFreeze(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result);

    [OperationContract]
    ResultStatus UnFreeze(DCObject maintenance, Request request, out Result result);

    [OperationContract]
    ResultStatus UnFreeze(DCObject maintenance);

    [OperationContract]
    ResultStatus UnFreeze();
  }
}
