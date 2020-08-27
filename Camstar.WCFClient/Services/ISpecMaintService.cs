// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISpecMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISpecMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_LoadESigDetails_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus SetCDOTypeName(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Parameters parameters,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SpecMaintMethod[] methods,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SpecMaint specMaint,
      SpecMaint_Request request,
      out SpecMaint_Result result);
  }
}
