// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IScaleFamilyMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IScaleFamilyMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_LoadESigDetails_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Parameters parameters,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ScaleFamilyMaintMethod[] methods,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ScaleFamilyMaint scaleFamilyMaint,
      ScaleFamilyMaint_Request request,
      out ScaleFamilyMaint_Result result);
  }
}
