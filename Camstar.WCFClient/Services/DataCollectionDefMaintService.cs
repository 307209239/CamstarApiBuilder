// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DataCollectionDefMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DataCollectionDefMaintService : RevisionedObjectMaintBase
  {
    public DataCollectionDefMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDataCollectionDefMaintService), userProfile);
    }

    public ResultStatus Delete(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).Delete(this._UserProfile, dataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(dataCollectionDefMaint, DataCollectionDefMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((DataCollectionDefMaint) null, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus Delete(DataCollectionDefMaint dataCollectionDefMaint)
    {
      return this.Delete(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus Delete(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.Delete(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, dataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(dataCollectionDefMaint, DataCollectionDefMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((DataCollectionDefMaint) null, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(DataCollectionDefMaint dataCollectionDefMaint)
    {
      return this.DeleteAllRevisions(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.DeleteAllRevisions(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).Freeze(this._UserProfile, dataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(dataCollectionDefMaint, DataCollectionDefMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((DataCollectionDefMaint) null, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus Freeze(DataCollectionDefMaint dataCollectionDefMaint)
    {
      return this.Freeze(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus Freeze(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.Freeze(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).GetWIPMsgs(this._UserProfile, dataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(dataCollectionDefMaint, DataCollectionDefMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DataCollectionDefMaint) null, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(DataCollectionDefMaint dataCollectionDefMaint)
    {
      return this.GetWIPMsgs(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.GetWIPMsgs(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).Load(this._UserProfile, dataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(dataCollectionDefMaint, DataCollectionDefMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DataCollectionDefMaint) null, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus Load(DataCollectionDefMaint dataCollectionDefMaint)
    {
      return this.Load(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus Load(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.Load(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_LoadESigDetails_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).LoadESigDetails(this._UserProfile, dataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(dataCollectionDefMaint, DataCollectionDefMaintMethods.LoadESigDetails, (DataCollectionDefMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DataCollectionDefMaint) null, (DataCollectionDefMaint_LoadESigDetails_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus LoadESigDetails(DataCollectionDefMaint dataCollectionDefMaint)
    {
      return this.LoadESigDetails(dataCollectionDefMaint, (DataCollectionDefMaint_LoadESigDetails_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.LoadESigDetails(dataCollectionDefMaint, (DataCollectionDefMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).New(this._UserProfile, dataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(dataCollectionDefMaint, DataCollectionDefMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((DataCollectionDefMaint) null, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus New(DataCollectionDefMaint dataCollectionDefMaint)
    {
      return this.New(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus New(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.New(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).NewCopy(this._UserProfile, dataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(dataCollectionDefMaint, DataCollectionDefMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((DataCollectionDefMaint) null, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus NewCopy(DataCollectionDefMaint dataCollectionDefMaint)
    {
      return this.NewCopy(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus NewCopy(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.NewCopy(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).NewRev(this._UserProfile, dataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(dataCollectionDefMaint, DataCollectionDefMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((DataCollectionDefMaint) null, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus NewRev(DataCollectionDefMaint dataCollectionDefMaint)
    {
      return this.NewRev(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus NewRev(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.NewRev(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).NewRevCopy(this._UserProfile, dataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(dataCollectionDefMaint, DataCollectionDefMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((DataCollectionDefMaint) null, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus NewRevCopy(DataCollectionDefMaint dataCollectionDefMaint)
    {
      return this.NewRevCopy(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.NewRevCopy(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).SaveAs(this._UserProfile, dataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(dataCollectionDefMaint, DataCollectionDefMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((DataCollectionDefMaint) null, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus SaveAs(DataCollectionDefMaint dataCollectionDefMaint)
    {
      return this.SaveAs(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus SaveAs(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.SaveAs(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).SaveAsRev(this._UserProfile, dataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(dataCollectionDefMaint, DataCollectionDefMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((DataCollectionDefMaint) null, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus SaveAsRev(DataCollectionDefMaint dataCollectionDefMaint)
    {
      return this.SaveAsRev(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.SaveAsRev(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).UnFreeze(this._UserProfile, dataCollectionDefMaint, parameters, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(dataCollectionDefMaint, DataCollectionDefMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) dataCollectionDefMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((DataCollectionDefMaint) null, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus UnFreeze(DataCollectionDefMaint dataCollectionDefMaint)
    {
      return this.UnFreeze(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.UnFreeze(dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject dataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((DataCollectionDefMaint) dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) parameters, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject dataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((DataCollectionDefMaint) dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) parameters, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject dataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((DataCollectionDefMaint) dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) parameters, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject dataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((DataCollectionDefMaint) dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) parameters, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject dataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.Delete((DataCollectionDefMaint) dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) parameters, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject dataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((DataCollectionDefMaint) dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) parameters, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject dataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DataCollectionDefMaint) dataCollectionDefMaint, (DataCollectionDefMaint_LoadESigDetails_Parameters) parameters, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject dataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.New((DataCollectionDefMaint) dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) parameters, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject dataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((DataCollectionDefMaint) dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) parameters, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject dataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((DataCollectionDefMaint) dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) parameters, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject dataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((DataCollectionDefMaint) dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) parameters, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject dataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.Load((DataCollectionDefMaint) dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) parameters, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject dataCollectionDefMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DataCollectionDefMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DataCollectionDefMaint) dataCollectionDefMaint, (DataCollectionDefMaint_Parameters) parameters, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      try
      {
        DataCollectionDefMaintMethod[] methods = new DataCollectionDefMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDataCollectionDefMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DataCollectionDefMaint cdo,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      try
      {
        return ((IDataCollectionDefMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DataCollectionDefMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((DataCollectionDefMaint) cdo, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.GetEnvironment((DataCollectionDefMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DataCollectionDefMaint cdo,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      result = (DataCollectionDefMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDataCollectionDefMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DataCollectionDefMaintMethod(cdo, DataCollectionDefMaintMethods.ExecuteTransaction, (DataCollectionDefMaint_Parameters) null));
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
        DataCollectionDefMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DataCollectionDefMaint) cdo, (DataCollectionDefMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DataCollectionDefMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (DataCollectionDefMaint_Request) null, out DataCollectionDefMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result)
    {
      return this.ExecuteTransaction((DataCollectionDefMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DataCollectionDefMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DataCollectionDefMaintMethod(cdo, DataCollectionDefMaintMethods.AddDataTransaction, (DataCollectionDefMaint_Parameters) null));
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
        return this.AddDataTransaction((DataCollectionDefMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
