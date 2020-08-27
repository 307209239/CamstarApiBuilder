// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IMenuDefinitionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IMenuDefinitionMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_LoadESigDetails_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Parameters parameters,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      MenuDefinitionMaintMethod[] methods,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      MenuDefinitionMaint menuDefinitionMaint,
      MenuDefinitionMaint_Request request,
      out MenuDefinitionMaint_Result result);
  }
}
