// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IExportTargetInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IExportTargetInquiryService
  {
    [OperationContract]
    ResultStatus GetStatusDetails(
      UserProfile userProfile,
      ExportTargetInquiry exportTargetInquiry,
      ExportTargetInquiry_Parameters parameters,
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ExportTargetInquiry exportTargetInquiry,
      ExportTargetInquiry_Parameters parameters,
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ExportTargetInquiryMethod[] methods,
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ExportTargetInquiry exportTargetInquiry,
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ExportTargetInquiry exportTargetInquiry,
      ExportTargetInquiry_Request request,
      out ExportTargetInquiry_Result result);
  }
}
