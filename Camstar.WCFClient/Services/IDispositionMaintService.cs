// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDispositionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDispositionMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DispositionMaint dispositionMaint,
      DispositionMaint_LoadESigDetails_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DispositionMaintMethod[] methods,
      DispositionMaint_Request request,
      out DispositionMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DispositionMaint dispositionMaint,
      DispositionMaint_Request request,
      out DispositionMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DispositionMaint dispositionMaint,
      DispositionMaint_Request request,
      out DispositionMaint_Result result);
  }
}
