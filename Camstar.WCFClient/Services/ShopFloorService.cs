// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloorService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ShopFloorService : UpdateBase
  {
    public ShopFloorService(UserProfile userProfile)
    {
      this.Initialize(typeof (IShopFloorService), userProfile);
    }

    public ResultStatus AccumulateSummaryHistoryData(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (AccumulateSummaryHistoryData), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).AccumulateSummaryHistoryData(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.AccumulateSummaryHistoryData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AccumulateSummaryHistoryData), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AccumulateSummaryHistoryData()
    {
      return this.AccumulateSummaryHistoryData((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus AccumulateSummaryHistoryData(ShopFloor shopFloor)
    {
      return this.AccumulateSummaryHistoryData(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus AccumulateSummaryHistoryData(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.AccumulateSummaryHistoryData(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus AddESigRequirement(
      ShopFloor shopFloor,
      ShopFloor_AddESigRequirement_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (AddESigRequirement), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).AddESigRequirement(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.AddESigRequirement, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddESigRequirement), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddESigRequirement()
    {
      return this.AddESigRequirement((ShopFloor) null, (ShopFloor_AddESigRequirement_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus AddESigRequirement(ShopFloor shopFloor)
    {
      return this.AddESigRequirement(shopFloor, (ShopFloor_AddESigRequirement_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus AddESigRequirement(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.AddESigRequirement(shopFloor, (ShopFloor_AddESigRequirement_Parameters) null, request, out result);
    }

    public ResultStatus AddHistorySummary(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (AddHistorySummary), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).AddHistorySummary(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.AddHistorySummary, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddHistorySummary), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddHistorySummary()
    {
      return this.AddHistorySummary((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus AddHistorySummary(ShopFloor shopFloor)
    {
      return this.AddHistorySummary(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus AddHistorySummary(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.AddHistorySummary(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus AddMassUpdateStatement(
      ShopFloor shopFloor,
      ShopFloor_AddMassUpdateStatement_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (AddMassUpdateStatement), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).AddMassUpdateStatement(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.AddMassUpdateStatement, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddMassUpdateStatement), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddMassUpdateStatement()
    {
      return this.AddMassUpdateStatement((ShopFloor) null, (ShopFloor_AddMassUpdateStatement_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus AddMassUpdateStatement(ShopFloor shopFloor)
    {
      return this.AddMassUpdateStatement(shopFloor, (ShopFloor_AddMassUpdateStatement_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus AddMassUpdateStatement(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.AddMassUpdateStatement(shopFloor, (ShopFloor_AddMassUpdateStatement_Parameters) null, request, out result);
    }

    public ResultStatus AddTrainingRequirmentsToESigRequirements(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (AddTrainingRequirmentsToESigRequirements), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).AddTrainingRequirmentsToESigRequirements(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.AddTrainingRequirmentsToESigRequirements, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddTrainingRequirmentsToESigRequirements), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddTrainingRequirmentsToESigRequirements()
    {
      return this.AddTrainingRequirmentsToESigRequirements((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus AddTrainingRequirmentsToESigRequirements(ShopFloor shopFloor)
    {
      return this.AddTrainingRequirmentsToESigRequirements(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus AddTrainingRequirmentsToESigRequirements(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.AddTrainingRequirmentsToESigRequirements(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ApplyDetails(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ApplyDetails), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ApplyDetails(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ApplyDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ApplyDetails), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ApplyDetails()
    {
      return this.ApplyDetails((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ApplyDetails(ShopFloor shopFloor)
    {
      return this.ApplyDetails(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ApplyDetails(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ApplyDetails(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ApplyParametricDetails(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ApplyParametricDetails), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ApplyParametricDetails(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ApplyParametricDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ApplyParametricDetails), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ApplyParametricDetails()
    {
      return this.ApplyParametricDetails((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ApplyParametricDetails(ShopFloor shopFloor)
    {
      return this.ApplyParametricDetails(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ApplyParametricDetails(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ApplyParametricDetails(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ApplyServiceDetail(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ApplyServiceDetail), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ApplyServiceDetail(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ApplyServiceDetail, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ApplyServiceDetail), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ApplyServiceDetail()
    {
      return this.ApplyServiceDetail((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ApplyServiceDetail(ShopFloor shopFloor)
    {
      return this.ApplyServiceDetail(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ApplyServiceDetail(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ApplyServiceDetail(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ApplyServiceDetails(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ApplyServiceDetails), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ApplyServiceDetails(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ApplyServiceDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ApplyServiceDetails), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ApplyServiceDetails()
    {
      return this.ApplyServiceDetails((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ApplyServiceDetails(ShopFloor shopFloor)
    {
      return this.ApplyServiceDetails(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ApplyServiceDetails(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ApplyServiceDetails(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus AuthorizeSigner(
      ShopFloor shopFloor,
      ShopFloor_AuthorizeSigner_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (AuthorizeSigner), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).AuthorizeSigner(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.AuthorizeSigner, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AuthorizeSigner), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AuthorizeSigner()
    {
      return this.AuthorizeSigner((ShopFloor) null, (ShopFloor_AuthorizeSigner_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus AuthorizeSigner(ShopFloor shopFloor)
    {
      return this.AuthorizeSigner(shopFloor, (ShopFloor_AuthorizeSigner_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus AuthorizeSigner(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.AuthorizeSigner(shopFloor, (ShopFloor_AuthorizeSigner_Parameters) null, request, out result);
    }

    public ResultStatus CheckRolePermissions(
      ShopFloor shopFloor,
      ShopFloor_CheckRolePermissions_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (CheckRolePermissions), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).CheckRolePermissions(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.CheckRolePermissions, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CheckRolePermissions), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CheckRolePermissions()
    {
      return this.CheckRolePermissions((ShopFloor) null, (ShopFloor_CheckRolePermissions_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus CheckRolePermissions(ShopFloor shopFloor)
    {
      return this.CheckRolePermissions(shopFloor, (ShopFloor_CheckRolePermissions_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus CheckRolePermissions(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.CheckRolePermissions(shopFloor, (ShopFloor_CheckRolePermissions_Parameters) null, request, out result);
    }

    public ResultStatus CreateHistoryMainline(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (CreateHistoryMainline), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).CreateHistoryMainline(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.CreateHistoryMainline, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateHistoryMainline), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateHistoryMainline()
    {
      return this.CreateHistoryMainline((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus CreateHistoryMainline(ShopFloor shopFloor)
    {
      return this.CreateHistoryMainline(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus CreateHistoryMainline(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.CreateHistoryMainline(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).CreateParametricData(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus CreateParametricData(ShopFloor shopFloor)
    {
      return this.CreateParametricData(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus CreateParametricData(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.CreateParametricData(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus DataPointConvertListToResultset(
      ShopFloor shopFloor,
      ShopFloor_DataPointConvertListToResultset_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (DataPointConvertListToResultset), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).DataPointConvertListToResultset(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.DataPointConvertListToResultset, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DataPointConvertListToResultset), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DataPointConvertListToResultset()
    {
      return this.DataPointConvertListToResultset((ShopFloor) null, (ShopFloor_DataPointConvertListToResultset_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus DataPointConvertListToResultset(ShopFloor shopFloor)
    {
      return this.DataPointConvertListToResultset(shopFloor, (ShopFloor_DataPointConvertListToResultset_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus DataPointConvertListToResultset(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.DataPointConvertListToResultset(shopFloor, (ShopFloor_DataPointConvertListToResultset_Parameters) null, request, out result);
    }

    public ResultStatus DownloadFile(
      ShopFloor shopFloor,
      ShopFloor_DownloadFile_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (DownloadFile), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).DownloadFile(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.DownloadFile, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DownloadFile), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DownloadFile()
    {
      return this.DownloadFile((ShopFloor) null, (ShopFloor_DownloadFile_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus DownloadFile(ShopFloor shopFloor)
    {
      return this.DownloadFile(shopFloor, (ShopFloor_DownloadFile_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus DownloadFile(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.DownloadFile(shopFloor, (ShopFloor_DownloadFile_Parameters) null, request, out result);
    }

    public ResultStatus EnforceDispatchRule(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (EnforceDispatchRule), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).EnforceDispatchRule(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.EnforceDispatchRule, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (EnforceDispatchRule), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus EnforceDispatchRule()
    {
      return this.EnforceDispatchRule((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus EnforceDispatchRule(ShopFloor shopFloor)
    {
      return this.EnforceDispatchRule(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus EnforceDispatchRule(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.EnforceDispatchRule(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus EvaluateLabelTags(
      ShopFloor shopFloor,
      ShopFloor_EvaluateLabelTags_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (EvaluateLabelTags), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).EvaluateLabelTags(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.EvaluateLabelTags, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (EvaluateLabelTags), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus EvaluateLabelTags()
    {
      return this.EvaluateLabelTags((ShopFloor) null, (ShopFloor_EvaluateLabelTags_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus EvaluateLabelTags(ShopFloor shopFloor)
    {
      return this.EvaluateLabelTags(shopFloor, (ShopFloor_EvaluateLabelTags_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus EvaluateLabelTags(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.EvaluateLabelTags(shopFloor, (ShopFloor_EvaluateLabelTags_Parameters) null, request, out result);
    }

    public ResultStatus Execute(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Execute), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Execute(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Execute, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Execute), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Execute()
    {
      return this.Execute((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Execute(ShopFloor shopFloor)
    {
      return this.Execute(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Execute(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Execute(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus Execute_User(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Execute_User), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Execute_User(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Execute_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Execute_User), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Execute_User()
    {
      return this.Execute_User((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Execute_User(ShopFloor shopFloor)
    {
      return this.Execute_User(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Execute_User(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Execute_User(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ExecuteTransactionTask(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransactionTask), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ExecuteTransactionTask(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ExecuteTransactionTask, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransactionTask), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExecuteTransactionTask()
    {
      return this.ExecuteTransactionTask((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ExecuteTransactionTask(ShopFloor shopFloor)
    {
      return this.ExecuteTransactionTask(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ExecuteTransactionTask(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ExecuteTransactionTask(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus FinishModifyingEntity(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (FinishModifyingEntity), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).FinishModifyingEntity(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.FinishModifyingEntity, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (FinishModifyingEntity), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus FinishModifyingEntity()
    {
      return this.FinishModifyingEntity((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus FinishModifyingEntity(ShopFloor shopFloor)
    {
      return this.FinishModifyingEntity(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus FinishModifyingEntity(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.FinishModifyingEntity(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetActions(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetActions(ShopFloor shopFloor)
    {
      return this.GetActions(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetActions(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetActions(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus GetAttributeParent(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetAttributeParent), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetAttributeParent(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetAttributeParent, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAttributeParent), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAttributeParent()
    {
      return this.GetAttributeParent((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetAttributeParent(ShopFloor shopFloor)
    {
      return this.GetAttributeParent(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetAttributeParent(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetAttributeParent(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus GetComputation(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetComputation), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetComputation(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetComputation), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetComputation()
    {
      return this.GetComputation((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetComputation(ShopFloor shopFloor)
    {
      return this.GetComputation(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetComputation(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetComputation(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus GetComputationParams(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetComputationParams), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetComputationParams(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetComputationParams, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetComputationParams), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetComputationParams()
    {
      return this.GetComputationParams((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetComputationParams(ShopFloor shopFloor)
    {
      return this.GetComputationParams(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetComputationParams(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetComputationParams(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus GetComputationParamsForDataPoints(
      ShopFloor shopFloor,
      ShopFloor_GetComputationParamsForDataPoints_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetComputationParamsForDataPoints), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetComputationParamsForDataPoints(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetComputationParamsForDataPoints, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetComputationParamsForDataPoints), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetComputationParamsForDataPoints()
    {
      return this.GetComputationParamsForDataPoints((ShopFloor) null, (ShopFloor_GetComputationParamsForDataPoints_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetComputationParamsForDataPoints(ShopFloor shopFloor)
    {
      return this.GetComputationParamsForDataPoints(shopFloor, (ShopFloor_GetComputationParamsForDataPoints_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetComputationParamsForDataPoints(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetComputationParamsForDataPoints(shopFloor, (ShopFloor_GetComputationParamsForDataPoints_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPointListSelectionValues(
      ShopFloor shopFloor,
      ShopFloor_GetDataPointListSelectionValues_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetDataPointListSelectionValues), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetDataPointListSelectionValues(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetDataPointListSelectionValues, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPointListSelectionValues), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPointListSelectionValues()
    {
      return this.GetDataPointListSelectionValues((ShopFloor) null, (ShopFloor_GetDataPointListSelectionValues_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDataPointListSelectionValues(ShopFloor shopFloor)
    {
      return this.GetDataPointListSelectionValues(shopFloor, (ShopFloor_GetDataPointListSelectionValues_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDataPointListSelectionValues(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetDataPointListSelectionValues(shopFloor, (ShopFloor_GetDataPointListSelectionValues_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPointObjectGroupSelectionValues(
      ShopFloor shopFloor,
      ShopFloor_GetDataPointObjectGroupSelectionValues_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetDataPointObjectGroupSelectionValues), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetDataPointObjectGroupSelectionValues(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetDataPointObjectGroupSelectionValues, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPointObjectGroupSelectionValues), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPointObjectGroupSelectionValues()
    {
      return this.GetDataPointObjectGroupSelectionValues((ShopFloor) null, (ShopFloor_GetDataPointObjectGroupSelectionValues_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDataPointObjectGroupSelectionValues(ShopFloor shopFloor)
    {
      return this.GetDataPointObjectGroupSelectionValues(shopFloor, (ShopFloor_GetDataPointObjectGroupSelectionValues_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDataPointObjectGroupSelectionValues(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetDataPointObjectGroupSelectionValues(shopFloor, (ShopFloor_GetDataPointObjectGroupSelectionValues_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPointQuerySelectionValues(
      ShopFloor shopFloor,
      ShopFloor_GetDataPointQuerySelectionValues_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetDataPointQuerySelectionValues), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetDataPointQuerySelectionValues(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetDataPointQuerySelectionValues, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPointQuerySelectionValues), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPointQuerySelectionValues()
    {
      return this.GetDataPointQuerySelectionValues((ShopFloor) null, (ShopFloor_GetDataPointQuerySelectionValues_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDataPointQuerySelectionValues(ShopFloor shopFloor)
    {
      return this.GetDataPointQuerySelectionValues(shopFloor, (ShopFloor_GetDataPointQuerySelectionValues_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDataPointQuerySelectionValues(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetDataPointQuerySelectionValues(shopFloor, (ShopFloor_GetDataPointQuerySelectionValues_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetDataPoints(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDataPoints(ShopFloor shopFloor)
    {
      return this.GetDataPoints(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDataPoints(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetDataPoints(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPointStaticSelectionValues(
      ShopFloor shopFloor,
      ShopFloor_GetDataPointStaticSelectionValues_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetDataPointStaticSelectionValues), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetDataPointStaticSelectionValues(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetDataPointStaticSelectionValues, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPointStaticSelectionValues), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPointStaticSelectionValues()
    {
      return this.GetDataPointStaticSelectionValues((ShopFloor) null, (ShopFloor_GetDataPointStaticSelectionValues_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDataPointStaticSelectionValues(ShopFloor shopFloor)
    {
      return this.GetDataPointStaticSelectionValues(shopFloor, (ShopFloor_GetDataPointStaticSelectionValues_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDataPointStaticSelectionValues(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetDataPointStaticSelectionValues(shopFloor, (ShopFloor_GetDataPointStaticSelectionValues_Parameters) null, request, out result);
    }

    public ResultStatus GetDefaultDispatchList(
      ShopFloor shopFloor,
      ShopFloor_GetDefaultDispatchList_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetDefaultDispatchList), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetDefaultDispatchList(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetDefaultDispatchList, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDefaultDispatchList), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDefaultDispatchList()
    {
      return this.GetDefaultDispatchList((ShopFloor) null, (ShopFloor_GetDefaultDispatchList_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDefaultDispatchList(ShopFloor shopFloor)
    {
      return this.GetDefaultDispatchList(shopFloor, (ShopFloor_GetDefaultDispatchList_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDefaultDispatchList(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetDefaultDispatchList(shopFloor, (ShopFloor_GetDefaultDispatchList_Parameters) null, request, out result);
    }

    public ResultStatus GetDispatchList(
      ShopFloor shopFloor,
      ShopFloor_GetDispatchList_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetDispatchList), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetDispatchList(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetDispatchList, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDispatchList), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDispatchList()
    {
      return this.GetDispatchList((ShopFloor) null, (ShopFloor_GetDispatchList_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDispatchList(ShopFloor shopFloor)
    {
      return this.GetDispatchList(shopFloor, (ShopFloor_GetDispatchList_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDispatchList(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetDispatchList(shopFloor, (ShopFloor_GetDispatchList_Parameters) null, request, out result);
    }

    public ResultStatus GetDispatchObject(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetDispatchObject), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetDispatchObject(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetDispatchObject, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDispatchObject), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDispatchObject()
    {
      return this.GetDispatchObject((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDispatchObject(ShopFloor shopFloor)
    {
      return this.GetDispatchObject(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetDispatchObject(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetDispatchObject(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus GetESigRequirementFromSpec(
      ShopFloor shopFloor,
      ShopFloor_GetESigRequirementFromSpec_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetESigRequirementFromSpec), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetESigRequirementFromSpec(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetESigRequirementFromSpec, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetESigRequirementFromSpec), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetESigRequirementFromSpec()
    {
      return this.GetESigRequirementFromSpec((ShopFloor) null, (ShopFloor_GetESigRequirementFromSpec_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetESigRequirementFromSpec(ShopFloor shopFloor)
    {
      return this.GetESigRequirementFromSpec(shopFloor, (ShopFloor_GetESigRequirementFromSpec_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetESigRequirementFromSpec(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetESigRequirementFromSpec(shopFloor, (ShopFloor_GetESigRequirementFromSpec_Parameters) null, request, out result);
    }

    public ResultStatus GetESigRequirements(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetESigRequirements), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetESigRequirements(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetESigRequirements, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetESigRequirements), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetESigRequirements()
    {
      return this.GetESigRequirements((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetESigRequirements(ShopFloor shopFloor)
    {
      return this.GetESigRequirements(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetESigRequirements(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetESigRequirements(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus GetESigRequirementsFromTxnMap(
      ShopFloor shopFloor,
      ShopFloor_GetESigRequirementsFromTxnMap_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetESigRequirementsFromTxnMap), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetESigRequirementsFromTxnMap(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetESigRequirementsFromTxnMap, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetESigRequirementsFromTxnMap), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetESigRequirementsFromTxnMap()
    {
      return this.GetESigRequirementsFromTxnMap((ShopFloor) null, (ShopFloor_GetESigRequirementsFromTxnMap_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetESigRequirementsFromTxnMap(ShopFloor shopFloor)
    {
      return this.GetESigRequirementsFromTxnMap(shopFloor, (ShopFloor_GetESigRequirementsFromTxnMap_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetESigRequirementsFromTxnMap(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetESigRequirementsFromTxnMap(shopFloor, (ShopFloor_GetESigRequirementsFromTxnMap_Parameters) null, request, out result);
    }

    public ResultStatus GetLabelInformation(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetLabelInformation), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetLabelInformation(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetLabelInformation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetLabelInformation), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetLabelInformation()
    {
      return this.GetLabelInformation((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetLabelInformation(ShopFloor shopFloor)
    {
      return this.GetLabelInformation(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetLabelInformation(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetLabelInformation(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus GetLabelInformationFromLabelMap(
      ShopFloor shopFloor,
      ShopFloor_GetLabelInformationFromLabelMap_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetLabelInformationFromLabelMap), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetLabelInformationFromLabelMap(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetLabelInformationFromLabelMap, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetLabelInformationFromLabelMap), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetLabelInformationFromLabelMap()
    {
      return this.GetLabelInformationFromLabelMap((ShopFloor) null, (ShopFloor_GetLabelInformationFromLabelMap_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetLabelInformationFromLabelMap(ShopFloor shopFloor)
    {
      return this.GetLabelInformationFromLabelMap(shopFloor, (ShopFloor_GetLabelInformationFromLabelMap_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetLabelInformationFromLabelMap(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetLabelInformationFromLabelMap(shopFloor, (ShopFloor_GetLabelInformationFromLabelMap_Parameters) null, request, out result);
    }

    public ResultStatus GetLabelInformationFromPrinterLabel(
      ShopFloor shopFloor,
      ShopFloor_GetLabelInformationFromPrinterLabel_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetLabelInformationFromPrinterLabel), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetLabelInformationFromPrinterLabel(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetLabelInformationFromPrinterLabel, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetLabelInformationFromPrinterLabel), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetLabelInformationFromPrinterLabel()
    {
      return this.GetLabelInformationFromPrinterLabel((ShopFloor) null, (ShopFloor_GetLabelInformationFromPrinterLabel_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetLabelInformationFromPrinterLabel(ShopFloor shopFloor)
    {
      return this.GetLabelInformationFromPrinterLabel(shopFloor, (ShopFloor_GetLabelInformationFromPrinterLabel_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetLabelInformationFromPrinterLabel(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetLabelInformationFromPrinterLabel(shopFloor, (ShopFloor_GetLabelInformationFromPrinterLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetTrainingRecord(
      ShopFloor shopFloor,
      ShopFloor_GetTrainingRecord_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetTrainingRecord), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetTrainingRecord(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetTrainingRecord, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetTrainingRecord), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetTrainingRecord()
    {
      return this.GetTrainingRecord((ShopFloor) null, (ShopFloor_GetTrainingRecord_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetTrainingRecord(ShopFloor shopFloor)
    {
      return this.GetTrainingRecord(shopFloor, (ShopFloor_GetTrainingRecord_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetTrainingRecord(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetTrainingRecord(shopFloor, (ShopFloor_GetTrainingRecord_Parameters) null, request, out result);
    }

    public ResultStatus GetTrainingRequirements(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetTrainingRequirements), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetTrainingRequirements(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetTrainingRequirements, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetTrainingRequirements), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetTrainingRequirements()
    {
      return this.GetTrainingRequirements((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetTrainingRequirements(ShopFloor shopFloor)
    {
      return this.GetTrainingRequirements(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetTrainingRequirements(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetTrainingRequirements(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).GetWIPMsgs(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetWIPMsgs(ShopFloor shopFloor)
    {
      return this.GetWIPMsgs(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetWIPMsgs(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus InitDispatchQueryParams(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (InitDispatchQueryParams), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).InitDispatchQueryParams(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.InitDispatchQueryParams, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (InitDispatchQueryParams), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus InitDispatchQueryParams()
    {
      return this.InitDispatchQueryParams((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus InitDispatchQueryParams(ShopFloor shopFloor)
    {
      return this.InitDispatchQueryParams(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus InitDispatchQueryParams(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.InitDispatchQueryParams(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus InitializeHistoryMainline(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (InitializeHistoryMainline), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).InitializeHistoryMainline(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.InitializeHistoryMainline, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (InitializeHistoryMainline), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus InitializeHistoryMainline()
    {
      return this.InitializeHistoryMainline((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus InitializeHistoryMainline(ShopFloor shopFloor)
    {
      return this.InitializeHistoryMainline(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus InitializeHistoryMainline(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.InitializeHistoryMainline(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Load(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Load(ShopFloor shopFloor)
    {
      return this.Load(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Load(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Load(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ShopFloor shopFloor,
      ShopFloor_LoadESigDetails_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).LoadESigDetails(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.LoadESigDetails, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ShopFloor) null, (ShopFloor_LoadESigDetails_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus LoadESigDetails(ShopFloor shopFloor)
    {
      return this.LoadESigDetails(shopFloor, (ShopFloor_LoadESigDetails_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus LoadESigDetails(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.LoadESigDetails(shopFloor, (ShopFloor_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ModifyEntity(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ModifyEntity), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ModifyEntity(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ModifyEntity, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ModifyEntity), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ModifyEntity()
    {
      return this.ModifyEntity((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ModifyEntity(ShopFloor shopFloor)
    {
      return this.ModifyEntity(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ModifyEntity(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ModifyEntity(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus OverrideDispatchEnforcement(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (OverrideDispatchEnforcement), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).OverrideDispatchEnforcement(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.OverrideDispatchEnforcement, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (OverrideDispatchEnforcement), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus OverrideDispatchEnforcement()
    {
      return this.OverrideDispatchEnforcement((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus OverrideDispatchEnforcement(ShopFloor shopFloor)
    {
      return this.OverrideDispatchEnforcement(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus OverrideDispatchEnforcement(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.OverrideDispatchEnforcement(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus PreExecute_User(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (PreExecute_User), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).PreExecute_User(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.PreExecute_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreExecute_User), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreExecute_User()
    {
      return this.PreExecute_User((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus PreExecute_User(ShopFloor shopFloor)
    {
      return this.PreExecute_User(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus PreExecute_User(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.PreExecute_User(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus PreValidate(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (PreValidate), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).PreValidate(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.PreValidate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreValidate), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreValidate()
    {
      return this.PreValidate((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus PreValidate(ShopFloor shopFloor)
    {
      return this.PreValidate(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus PreValidate(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.PreValidate(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus PreValidate_Generic(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (PreValidate_Generic), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).PreValidate_Generic(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.PreValidate_Generic, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreValidate_Generic), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreValidate_Generic()
    {
      return this.PreValidate_Generic((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus PreValidate_Generic(ShopFloor shopFloor)
    {
      return this.PreValidate_Generic(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus PreValidate_Generic(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.PreValidate_Generic(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus PreValidate_Specific(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (PreValidate_Specific), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).PreValidate_Specific(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.PreValidate_Specific, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreValidate_Specific), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreValidate_Specific()
    {
      return this.PreValidate_Specific((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus PreValidate_Specific(ShopFloor shopFloor)
    {
      return this.PreValidate_Specific(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus PreValidate_Specific(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.PreValidate_Specific(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus PreValidate_User(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (PreValidate_User), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).PreValidate_User(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.PreValidate_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreValidate_User), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreValidate_User()
    {
      return this.PreValidate_User((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus PreValidate_User(ShopFloor shopFloor)
    {
      return this.PreValidate_User(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus PreValidate_User(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.PreValidate_User(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus PrintLabel(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (PrintLabel), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).PrintLabel(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.PrintLabel, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PrintLabel), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PrintLabel()
    {
      return this.PrintLabel((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus PrintLabel(ShopFloor shopFloor)
    {
      return this.PrintLabel(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus PrintLabel(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.PrintLabel(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ProcessAfterCommit(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ProcessAfterCommit), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ProcessAfterCommit(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ProcessAfterCommit, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessAfterCommit), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessAfterCommit()
    {
      return this.ProcessAfterCommit((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessAfterCommit(ShopFloor shopFloor)
    {
      return this.ProcessAfterCommit(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessAfterCommit(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ProcessAfterCommit(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ProcessAfterCommit_User(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ProcessAfterCommit_User), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ProcessAfterCommit_User(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ProcessAfterCommit_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessAfterCommit_User), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessAfterCommit_User()
    {
      return this.ProcessAfterCommit_User((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessAfterCommit_User(ShopFloor shopFloor)
    {
      return this.ProcessAfterCommit_User(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessAfterCommit_User(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ProcessAfterCommit_User(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ProcessApplicationExtensions(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ProcessApplicationExtensions), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ProcessApplicationExtensions(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ProcessApplicationExtensions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessApplicationExtensions), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessApplicationExtensions()
    {
      return this.ProcessApplicationExtensions((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessApplicationExtensions(ShopFloor shopFloor)
    {
      return this.ProcessApplicationExtensions(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessApplicationExtensions(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ProcessApplicationExtensions(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ProcessComputation(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessComputation(ShopFloor shopFloor)
    {
      return this.ProcessComputation(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessComputation(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ProcessComputation(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputationParams(
      ShopFloor shopFloor,
      ShopFloor_ProcessComputationParams_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ProcessComputationParams), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ProcessComputationParams(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ProcessComputationParams, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputationParams), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputationParams()
    {
      return this.ProcessComputationParams((ShopFloor) null, (ShopFloor_ProcessComputationParams_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessComputationParams(ShopFloor shopFloor)
    {
      return this.ProcessComputationParams(shopFloor, (ShopFloor_ProcessComputationParams_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessComputationParams(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ProcessComputationParams(shopFloor, (ShopFloor_ProcessComputationParams_Parameters) null, request, out result);
    }

    public ResultStatus ProcessElectronicProcedures(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ProcessElectronicProcedures), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ProcessElectronicProcedures(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ProcessElectronicProcedures, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessElectronicProcedures), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessElectronicProcedures()
    {
      return this.ProcessElectronicProcedures((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessElectronicProcedures(ShopFloor shopFloor)
    {
      return this.ProcessElectronicProcedures(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessElectronicProcedures(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ProcessElectronicProcedures(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ProcessElectronicSignatures(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ProcessElectronicSignatures), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ProcessElectronicSignatures(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ProcessElectronicSignatures, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessElectronicSignatures), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessElectronicSignatures()
    {
      return this.ProcessElectronicSignatures((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessElectronicSignatures(ShopFloor shopFloor)
    {
      return this.ProcessElectronicSignatures(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessElectronicSignatures(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ProcessElectronicSignatures(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ProcessLabelInformation(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ProcessLabelInformation), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ProcessLabelInformation(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ProcessLabelInformation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessLabelInformation), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessLabelInformation()
    {
      return this.ProcessLabelInformation((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessLabelInformation(ShopFloor shopFloor)
    {
      return this.ProcessLabelInformation(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessLabelInformation(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ProcessLabelInformation(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ProcessMaintenanceMgmt(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ProcessMaintenanceMgmt), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ProcessMaintenanceMgmt(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ProcessMaintenanceMgmt, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessMaintenanceMgmt), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessMaintenanceMgmt()
    {
      return this.ProcessMaintenanceMgmt((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessMaintenanceMgmt(ShopFloor shopFloor)
    {
      return this.ProcessMaintenanceMgmt(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessMaintenanceMgmt(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ProcessMaintenanceMgmt(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ProcessMasterRecipe(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ProcessMasterRecipe), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ProcessMasterRecipe(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ProcessMasterRecipe, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessMasterRecipe), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessMasterRecipe()
    {
      return this.ProcessMasterRecipe((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessMasterRecipe(ShopFloor shopFloor)
    {
      return this.ProcessMasterRecipe(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessMasterRecipe(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ProcessMasterRecipe(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ProcessNonConformances(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ProcessNonConformances), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ProcessNonConformances(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ProcessNonConformances, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessNonConformances), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessNonConformances()
    {
      return this.ProcessNonConformances((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessNonConformances(ShopFloor shopFloor)
    {
      return this.ProcessNonConformances(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ProcessNonConformances(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ProcessNonConformances(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus RecordMainlinePostHistory(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (RecordMainlinePostHistory), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).RecordMainlinePostHistory(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.RecordMainlinePostHistory, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RecordMainlinePostHistory), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RecordMainlinePostHistory()
    {
      return this.RecordMainlinePostHistory((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RecordMainlinePostHistory(ShopFloor shopFloor)
    {
      return this.RecordMainlinePostHistory(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RecordMainlinePostHistory(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.RecordMainlinePostHistory(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus RecordMainlinePreHistory(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (RecordMainlinePreHistory), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).RecordMainlinePreHistory(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.RecordMainlinePreHistory, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RecordMainlinePreHistory), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RecordMainlinePreHistory()
    {
      return this.RecordMainlinePreHistory((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RecordMainlinePreHistory(ShopFloor shopFloor)
    {
      return this.RecordMainlinePreHistory(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RecordMainlinePreHistory(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.RecordMainlinePreHistory(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus RecordPostHistory(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (RecordPostHistory), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).RecordPostHistory(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.RecordPostHistory, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RecordPostHistory), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RecordPostHistory()
    {
      return this.RecordPostHistory((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RecordPostHistory(ShopFloor shopFloor)
    {
      return this.RecordPostHistory(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RecordPostHistory(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.RecordPostHistory(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus RecordPreHistory(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (RecordPreHistory), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).RecordPreHistory(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.RecordPreHistory, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RecordPreHistory), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RecordPreHistory()
    {
      return this.RecordPreHistory((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RecordPreHistory(ShopFloor shopFloor)
    {
      return this.RecordPreHistory(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RecordPreHistory(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.RecordPreHistory(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus RecordSummaryPostHistory(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (RecordSummaryPostHistory), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).RecordSummaryPostHistory(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.RecordSummaryPostHistory, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RecordSummaryPostHistory), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RecordSummaryPostHistory()
    {
      return this.RecordSummaryPostHistory((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RecordSummaryPostHistory(ShopFloor shopFloor)
    {
      return this.RecordSummaryPostHistory(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RecordSummaryPostHistory(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.RecordSummaryPostHistory(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus RecordSummaryPreHistory(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (RecordSummaryPreHistory), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).RecordSummaryPreHistory(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.RecordSummaryPreHistory, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RecordSummaryPreHistory), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RecordSummaryPreHistory()
    {
      return this.RecordSummaryPreHistory((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RecordSummaryPreHistory(ShopFloor shopFloor)
    {
      return this.RecordSummaryPreHistory(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RecordSummaryPreHistory(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.RecordSummaryPreHistory(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ReplaceHistoryMainline(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ReplaceHistoryMainline), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ReplaceHistoryMainline(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ReplaceHistoryMainline, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ReplaceHistoryMainline), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ReplaceHistoryMainline()
    {
      return this.ReplaceHistoryMainline((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ReplaceHistoryMainline(ShopFloor shopFloor)
    {
      return this.ReplaceHistoryMainline(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ReplaceHistoryMainline(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ReplaceHistoryMainline(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ReplaceOldHistoryMainline(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ReplaceOldHistoryMainline), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ReplaceOldHistoryMainline(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ReplaceOldHistoryMainline, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ReplaceOldHistoryMainline), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ReplaceOldHistoryMainline()
    {
      return this.ReplaceOldHistoryMainline((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ReplaceOldHistoryMainline(ShopFloor shopFloor)
    {
      return this.ReplaceOldHistoryMainline(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ReplaceOldHistoryMainline(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ReplaceOldHistoryMainline(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ResolveParametricData(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ResolveParametricData(ShopFloor shopFloor)
    {
      return this.ResolveParametricData(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ResolveParametricData(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ResolveParametricData(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus RetrieveCalendarShift(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (RetrieveCalendarShift), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).RetrieveCalendarShift(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.RetrieveCalendarShift, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RetrieveCalendarShift), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RetrieveCalendarShift()
    {
      return this.RetrieveCalendarShift((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RetrieveCalendarShift(ShopFloor shopFloor)
    {
      return this.RetrieveCalendarShift(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus RetrieveCalendarShift(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.RetrieveCalendarShift(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus Sampling_ContainerSampleData(
      ShopFloor shopFloor,
      ShopFloor_Sampling_ContainerSampleData_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Sampling_ContainerSampleData), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Sampling_ContainerSampleData(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Sampling_ContainerSampleData, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Sampling_ContainerSampleData), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Sampling_ContainerSampleData()
    {
      return this.Sampling_ContainerSampleData((ShopFloor) null, (ShopFloor_Sampling_ContainerSampleData_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_ContainerSampleData(ShopFloor shopFloor)
    {
      return this.Sampling_ContainerSampleData(shopFloor, (ShopFloor_Sampling_ContainerSampleData_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_ContainerSampleData(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Sampling_ContainerSampleData(shopFloor, (ShopFloor_Sampling_ContainerSampleData_Parameters) null, request, out result);
    }

    public ResultStatus Sampling_EvaluateSwitchingRule(
      ShopFloor shopFloor,
      ShopFloor_Sampling_EvaluateSwitchingRule_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Sampling_EvaluateSwitchingRule), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Sampling_EvaluateSwitchingRule(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Sampling_EvaluateSwitchingRule, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Sampling_EvaluateSwitchingRule), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Sampling_EvaluateSwitchingRule()
    {
      return this.Sampling_EvaluateSwitchingRule((ShopFloor) null, (ShopFloor_Sampling_EvaluateSwitchingRule_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_EvaluateSwitchingRule(ShopFloor shopFloor)
    {
      return this.Sampling_EvaluateSwitchingRule(shopFloor, (ShopFloor_Sampling_EvaluateSwitchingRule_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_EvaluateSwitchingRule(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Sampling_EvaluateSwitchingRule(shopFloor, (ShopFloor_Sampling_EvaluateSwitchingRule_Parameters) null, request, out result);
    }

    public ResultStatus Sampling_GetDistributionListRecipients(
      ShopFloor shopFloor,
      ShopFloor_Sampling_GetDistributionListRecipients_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Sampling_GetDistributionListRecipients), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Sampling_GetDistributionListRecipients(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Sampling_GetDistributionListRecipients, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Sampling_GetDistributionListRecipients), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Sampling_GetDistributionListRecipients()
    {
      return this.Sampling_GetDistributionListRecipients((ShopFloor) null, (ShopFloor_Sampling_GetDistributionListRecipients_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_GetDistributionListRecipients(ShopFloor shopFloor)
    {
      return this.Sampling_GetDistributionListRecipients(shopFloor, (ShopFloor_Sampling_GetDistributionListRecipients_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_GetDistributionListRecipients(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Sampling_GetDistributionListRecipients(shopFloor, (ShopFloor_Sampling_GetDistributionListRecipients_Parameters) null, request, out result);
    }

    public ResultStatus Sampling_LotSampleData(
      ShopFloor shopFloor,
      ShopFloor_Sampling_LotSampleData_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Sampling_LotSampleData), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Sampling_LotSampleData(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Sampling_LotSampleData, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Sampling_LotSampleData), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Sampling_LotSampleData()
    {
      return this.Sampling_LotSampleData((ShopFloor) null, (ShopFloor_Sampling_LotSampleData_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_LotSampleData(ShopFloor shopFloor)
    {
      return this.Sampling_LotSampleData(shopFloor, (ShopFloor_Sampling_LotSampleData_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_LotSampleData(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Sampling_LotSampleData(shopFloor, (ShopFloor_Sampling_LotSampleData_Parameters) null, request, out result);
    }

    public ResultStatus Sampling_SendSwitchingRuleNotification(
      ShopFloor shopFloor,
      ShopFloor_Sampling_SendSwitchingRuleNotification_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Sampling_SendSwitchingRuleNotification), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Sampling_SendSwitchingRuleNotification(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Sampling_SendSwitchingRuleNotification, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Sampling_SendSwitchingRuleNotification), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Sampling_SendSwitchingRuleNotification()
    {
      return this.Sampling_SendSwitchingRuleNotification((ShopFloor) null, (ShopFloor_Sampling_SendSwitchingRuleNotification_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_SendSwitchingRuleNotification(ShopFloor shopFloor)
    {
      return this.Sampling_SendSwitchingRuleNotification(shopFloor, (ShopFloor_Sampling_SendSwitchingRuleNotification_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_SendSwitchingRuleNotification(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Sampling_SendSwitchingRuleNotification(shopFloor, (ShopFloor_Sampling_SendSwitchingRuleNotification_Parameters) null, request, out result);
    }

    public ResultStatus Sampling_SetupSampling(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Sampling_SetupSampling), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Sampling_SetupSampling(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Sampling_SetupSampling, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Sampling_SetupSampling), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Sampling_SetupSampling()
    {
      return this.Sampling_SetupSampling((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_SetupSampling(ShopFloor shopFloor)
    {
      return this.Sampling_SetupSampling(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_SetupSampling(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Sampling_SetupSampling(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus Sampling_SetupSamplingRequirement(
      ShopFloor shopFloor,
      ShopFloor_Sampling_SetupSamplingRequirement_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Sampling_SetupSamplingRequirement), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Sampling_SetupSamplingRequirement(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Sampling_SetupSamplingRequirement, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Sampling_SetupSamplingRequirement), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Sampling_SetupSamplingRequirement()
    {
      return this.Sampling_SetupSamplingRequirement((ShopFloor) null, (ShopFloor_Sampling_SetupSamplingRequirement_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_SetupSamplingRequirement(ShopFloor shopFloor)
    {
      return this.Sampling_SetupSamplingRequirement(shopFloor, (ShopFloor_Sampling_SetupSamplingRequirement_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Sampling_SetupSamplingRequirement(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Sampling_SetupSamplingRequirement(shopFloor, (ShopFloor_Sampling_SetupSamplingRequirement_Parameters) null, request, out result);
    }

    public ResultStatus SetHistoryMainlineTxnDates(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (SetHistoryMainlineTxnDates), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).SetHistoryMainlineTxnDates(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.SetHistoryMainlineTxnDates, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetHistoryMainlineTxnDates), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetHistoryMainlineTxnDates()
    {
      return this.SetHistoryMainlineTxnDates((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus SetHistoryMainlineTxnDates(ShopFloor shopFloor)
    {
      return this.SetHistoryMainlineTxnDates(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus SetHistoryMainlineTxnDates(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.SetHistoryMainlineTxnDates(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus StartModifyingEntity(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (StartModifyingEntity), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).StartModifyingEntity(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.StartModifyingEntity, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (StartModifyingEntity), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus StartModifyingEntity()
    {
      return this.StartModifyingEntity((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus StartModifyingEntity(ShopFloor shopFloor)
    {
      return this.StartModifyingEntity(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus StartModifyingEntity(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.StartModifyingEntity(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus UpdateCompletionMsg_PrintLabelFailure(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (UpdateCompletionMsg_PrintLabelFailure), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).UpdateCompletionMsg_PrintLabelFailure(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.UpdateCompletionMsg_PrintLabelFailure, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UpdateCompletionMsg_PrintLabelFailure), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UpdateCompletionMsg_PrintLabelFailure()
    {
      return this.UpdateCompletionMsg_PrintLabelFailure((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus UpdateCompletionMsg_PrintLabelFailure(ShopFloor shopFloor)
    {
      return this.UpdateCompletionMsg_PrintLabelFailure(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus UpdateCompletionMsg_PrintLabelFailure(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.UpdateCompletionMsg_PrintLabelFailure(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus UpdateCompletionMsg_PrintLabelSuccess(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (UpdateCompletionMsg_PrintLabelSuccess), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).UpdateCompletionMsg_PrintLabelSuccess(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.UpdateCompletionMsg_PrintLabelSuccess, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UpdateCompletionMsg_PrintLabelSuccess), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UpdateCompletionMsg_PrintLabelSuccess()
    {
      return this.UpdateCompletionMsg_PrintLabelSuccess((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus UpdateCompletionMsg_PrintLabelSuccess(ShopFloor shopFloor)
    {
      return this.UpdateCompletionMsg_PrintLabelSuccess(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus UpdateCompletionMsg_PrintLabelSuccess(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.UpdateCompletionMsg_PrintLabelSuccess(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus Validate(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Validate), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Validate(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Validate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Validate), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Validate()
    {
      return this.Validate((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Validate(ShopFloor shopFloor)
    {
      return this.Validate(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Validate(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Validate(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus Validate_Generic(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Validate_Generic), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Validate_Generic(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Validate_Generic, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Validate_Generic), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Validate_Generic()
    {
      return this.Validate_Generic((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Validate_Generic(ShopFloor shopFloor)
    {
      return this.Validate_Generic(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Validate_Generic(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Validate_Generic(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus Validate_Specific(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Validate_Specific), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Validate_Specific(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Validate_Specific, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Validate_Specific), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Validate_Specific()
    {
      return this.Validate_Specific((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Validate_Specific(ShopFloor shopFloor)
    {
      return this.Validate_Specific(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Validate_Specific(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Validate_Specific(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus Validate_User(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (Validate_User), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).Validate_User(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.Validate_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Validate_User), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Validate_User()
    {
      return this.Validate_User((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Validate_User(ShopFloor shopFloor)
    {
      return this.Validate_User(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus Validate_User(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.Validate_User(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ValidateApplicationExtensions(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ValidateApplicationExtensions), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ValidateApplicationExtensions(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ValidateApplicationExtensions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateApplicationExtensions), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateApplicationExtensions()
    {
      return this.ValidateApplicationExtensions((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateApplicationExtensions(ShopFloor shopFloor)
    {
      return this.ValidateApplicationExtensions(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateApplicationExtensions(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ValidateApplicationExtensions(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ValidateElectronicProcedures(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ValidateElectronicProcedures), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ValidateElectronicProcedures(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ValidateElectronicProcedures, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateElectronicProcedures), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateElectronicProcedures()
    {
      return this.ValidateElectronicProcedures((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateElectronicProcedures(ShopFloor shopFloor)
    {
      return this.ValidateElectronicProcedures(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateElectronicProcedures(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ValidateElectronicProcedures(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ValidateElectronicSignatures(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ValidateElectronicSignatures), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ValidateElectronicSignatures(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ValidateElectronicSignatures, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateElectronicSignatures), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateElectronicSignatures()
    {
      return this.ValidateElectronicSignatures((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateElectronicSignatures(ShopFloor shopFloor)
    {
      return this.ValidateElectronicSignatures(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateElectronicSignatures(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ValidateElectronicSignatures(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ValidateESigRequirement(
      ShopFloor shopFloor,
      ShopFloor_ValidateESigRequirement_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ValidateESigRequirement), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ValidateESigRequirement(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ValidateESigRequirement, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateESigRequirement), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateESigRequirement()
    {
      return this.ValidateESigRequirement((ShopFloor) null, (ShopFloor_ValidateESigRequirement_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateESigRequirement(ShopFloor shopFloor)
    {
      return this.ValidateESigRequirement(shopFloor, (ShopFloor_ValidateESigRequirement_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateESigRequirement(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ValidateESigRequirement(shopFloor, (ShopFloor_ValidateESigRequirement_Parameters) null, request, out result);
    }

    public ResultStatus ValidateMaintenanceMgmt(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ValidateMaintenanceMgmt), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ValidateMaintenanceMgmt(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ValidateMaintenanceMgmt, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateMaintenanceMgmt), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateMaintenanceMgmt()
    {
      return this.ValidateMaintenanceMgmt((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateMaintenanceMgmt(ShopFloor shopFloor)
    {
      return this.ValidateMaintenanceMgmt(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateMaintenanceMgmt(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ValidateMaintenanceMgmt(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ValidateMaintenanceUOM(
      ShopFloor shopFloor,
      ShopFloor_ValidateMaintenanceUOM_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ValidateMaintenanceUOM), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ValidateMaintenanceUOM(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ValidateMaintenanceUOM, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateMaintenanceUOM), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateMaintenanceUOM()
    {
      return this.ValidateMaintenanceUOM((ShopFloor) null, (ShopFloor_ValidateMaintenanceUOM_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateMaintenanceUOM(ShopFloor shopFloor)
    {
      return this.ValidateMaintenanceUOM(shopFloor, (ShopFloor_ValidateMaintenanceUOM_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateMaintenanceUOM(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ValidateMaintenanceUOM(shopFloor, (ShopFloor_ValidateMaintenanceUOM_Parameters) null, request, out result);
    }

    public ResultStatus ValidateMasterRecipe(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ValidateMasterRecipe), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ValidateMasterRecipe(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ValidateMasterRecipe, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateMasterRecipe), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateMasterRecipe()
    {
      return this.ValidateMasterRecipe((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateMasterRecipe(ShopFloor shopFloor)
    {
      return this.ValidateMasterRecipe(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateMasterRecipe(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ValidateMasterRecipe(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ValidateNonConformances(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ValidateNonConformances), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ValidateNonConformances(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ValidateNonConformances, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateNonConformances), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateNonConformances()
    {
      return this.ValidateNonConformances((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateNonConformances(ShopFloor shopFloor)
    {
      return this.ValidateNonConformances(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateNonConformances(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ValidateNonConformances(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ValidateResourceMaintenance(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ValidateResourceMaintenance), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ValidateResourceMaintenance(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ValidateResourceMaintenance, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateResourceMaintenance), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateResourceMaintenance()
    {
      return this.ValidateResourceMaintenance((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateResourceMaintenance(ShopFloor shopFloor)
    {
      return this.ValidateResourceMaintenance(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateResourceMaintenance(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ValidateResourceMaintenance(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus ValidateTrainingRequirement(
      ShopFloor shopFloor,
      ShopFloor_ValidateTrainingRequirement_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ValidateTrainingRequirement), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ValidateTrainingRequirement(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ValidateTrainingRequirement, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateTrainingRequirement), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateTrainingRequirement()
    {
      return this.ValidateTrainingRequirement((ShopFloor) null, (ShopFloor_ValidateTrainingRequirement_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateTrainingRequirement(ShopFloor shopFloor)
    {
      return this.ValidateTrainingRequirement(shopFloor, (ShopFloor_ValidateTrainingRequirement_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateTrainingRequirement(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ValidateTrainingRequirement(shopFloor, (ShopFloor_ValidateTrainingRequirement_Parameters) null, request, out result);
    }

    public ResultStatus ValidateTrainingRequirements(
      ShopFloor shopFloor,
      ShopFloor_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ValidateTrainingRequirements), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ValidateTrainingRequirements(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.ValidateTrainingRequirements, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateTrainingRequirements), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateTrainingRequirements()
    {
      return this.ValidateTrainingRequirements((ShopFloor) null, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateTrainingRequirements(ShopFloor shopFloor)
    {
      return this.ValidateTrainingRequirements(shopFloor, (ShopFloor_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ValidateTrainingRequirements(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ValidateTrainingRequirements(shopFloor, (ShopFloor_Parameters) null, request, out result);
    }

    public ResultStatus VerifyPasswordSignature(
      ShopFloor shopFloor,
      ShopFloor_VerifyPasswordSignature_Parameters parameters,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (VerifyPasswordSignature), (DCObject) shopFloor, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).VerifyPasswordSignature(this._UserProfile, shopFloor, parameters, request, out result) : this.AddMethod((Method) new ShopFloorMethod(shopFloor, ShopFloorMethods.VerifyPasswordSignature, (ShopFloor_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (VerifyPasswordSignature), res, (DCObject) shopFloor, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus VerifyPasswordSignature()
    {
      return this.VerifyPasswordSignature((ShopFloor) null, (ShopFloor_VerifyPasswordSignature_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus VerifyPasswordSignature(ShopFloor shopFloor)
    {
      return this.VerifyPasswordSignature(shopFloor, (ShopFloor_VerifyPasswordSignature_Parameters) null, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus VerifyPasswordSignature(
      ShopFloor shopFloor,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.VerifyPasswordSignature(shopFloor, (ShopFloor_VerifyPasswordSignature_Parameters) null, request, out result);
    }

    protected override ResultStatus OnLoad(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShopFloor_Result result1;
        ResultStatus resultStatus = this.Load((ShopFloor) shopFloor, (ShopFloor_Parameters) parameters, (ShopFloor_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject shopFloor,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShopFloor_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ShopFloor) shopFloor, (ShopFloor_Parameters) parameters, (ShopFloor_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      try
      {
        ShopFloorMethod[] methods = new ShopFloorMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IShopFloorService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShopFloor_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ShopFloor_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ShopFloor cdo,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      try
      {
        return ((IShopFloorService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShopFloor_Result result1;
        ResultStatus environment = this.GetEnvironment((ShopFloor) cdo, (ShopFloor_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.GetEnvironment((ShopFloor) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ShopFloor cdo,
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      result = (ShopFloor_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShopFloorService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ShopFloorMethod(cdo, ShopFloorMethods.ExecuteTransaction, (ShopFloor_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShopFloor_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ShopFloor) cdo, (ShopFloor_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ShopFloor cdo)
    {
      return this.ExecuteTransaction(cdo, (ShopFloor_Request) null, out ShopFloor_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ShopFloor_Request request,
      out ShopFloor_Result result)
    {
      return this.ExecuteTransaction((ShopFloor) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ShopFloor cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ShopFloorMethod(cdo, ShopFloorMethods.AddDataTransaction, (ShopFloor_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((ShopFloor) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
