﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.9031
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;



[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
[System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/")]
public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject
{
    
    private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
    
    private bool BoolValueField;
    
    private string StringValueField;
    
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData
    {
        get
        {
            return this.extensionDataField;
        }
        set
        {
            this.extensionDataField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public bool BoolValue
    {
        get
        {
            return this.BoolValueField;
        }
        set
        {
            this.BoolValueField = value;
        }
    }
    
    [System.Runtime.Serialization.DataMemberAttribute()]
    public string StringValue
    {
        get
        {
            return this.StringValueField;
        }
        set
        {
            this.StringValueField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IService")]
public interface IService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
    string GetData(int value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
    CompositeType GetDataUsingDataContract(CompositeType composite);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GenerateSpecification", ReplyAction="http://tempuri.org/IService/GenerateSpecificationResponse")]
    AllfleXML.FlexSpec.Specification GenerateSpecification(string sku);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IServiceChannel : IService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class ServiceClient : System.ServiceModel.ClientBase<IService>, IService
{
    
    public ServiceClient()
    {
    }
    
    public ServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string GetData(int value)
    {
        return base.Channel.GetData(value);
    }
    
    public CompositeType GetDataUsingDataContract(CompositeType composite)
    {
        return base.Channel.GetDataUsingDataContract(composite);
    }
    
    public AllfleXML.FlexSpec.Specification GenerateSpecification(string sku)
    {
        return base.Channel.GenerateSpecification(sku);
    }
}
namespace AllfleXML.FlexSpec
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Specification", Namespace="http://schemas.datacontract.org/2004/07/AllfleXML.FlexSpec")]
    public partial class Specification : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private AllfleXML.FlexSpec.Component[] Componentsk__BackingFieldField;
        
        private string Idk__BackingFieldField;
        
        private string MarkingCodek__BackingFieldField;
        
        private string Namek__BackingFieldField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Components>k__BackingField", IsRequired=true)]
        public AllfleXML.FlexSpec.Component[] Componentsk__BackingField
        {
            get
            {
                return this.Componentsk__BackingFieldField;
            }
            set
            {
                this.Componentsk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Id>k__BackingField", IsRequired=true)]
        public string Idk__BackingField
        {
            get
            {
                return this.Idk__BackingFieldField;
            }
            set
            {
                this.Idk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<MarkingCode>k__BackingField", IsRequired=true)]
        public string MarkingCodek__BackingField
        {
            get
            {
                return this.MarkingCodek__BackingFieldField;
            }
            set
            {
                this.MarkingCodek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Name>k__BackingField", IsRequired=true)]
        public string Namek__BackingField
        {
            get
            {
                return this.Namek__BackingFieldField;
            }
            set
            {
                this.Namek__BackingFieldField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Component", Namespace="http://schemas.datacontract.org/2004/07/AllfleXML.FlexSpec")]
    public partial class Component : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string Colork__BackingFieldField;
        
        private AllfleXML.FlexSpec.Color[] Colorsk__BackingFieldField;
        
        private string Descriptionk__BackingFieldField;
        
        private AllfleXML.FlexSpec.Face[] Facesk__BackingFieldField;
        
        private bool FixedColork__BackingFieldField;
        
        private int Indexk__BackingFieldField;
        
        private string ItemNumberk__BackingFieldField;
        
        private string Namek__BackingFieldField;
        
        private string Outlinek__BackingFieldField;
        
        private string ProductLinek__BackingFieldField;
        
        private string Silhouettek__BackingFieldField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Color>k__BackingField", IsRequired=true)]
        public string Colork__BackingField
        {
            get
            {
                return this.Colork__BackingFieldField;
            }
            set
            {
                this.Colork__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Colors>k__BackingField", IsRequired=true)]
        public AllfleXML.FlexSpec.Color[] Colorsk__BackingField
        {
            get
            {
                return this.Colorsk__BackingFieldField;
            }
            set
            {
                this.Colorsk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Description>k__BackingField", IsRequired=true)]
        public string Descriptionk__BackingField
        {
            get
            {
                return this.Descriptionk__BackingFieldField;
            }
            set
            {
                this.Descriptionk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Faces>k__BackingField", IsRequired=true)]
        public AllfleXML.FlexSpec.Face[] Facesk__BackingField
        {
            get
            {
                return this.Facesk__BackingFieldField;
            }
            set
            {
                this.Facesk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<FixedColor>k__BackingField", IsRequired=true)]
        public bool FixedColork__BackingField
        {
            get
            {
                return this.FixedColork__BackingFieldField;
            }
            set
            {
                this.FixedColork__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Index>k__BackingField", IsRequired=true)]
        public int Indexk__BackingField
        {
            get
            {
                return this.Indexk__BackingFieldField;
            }
            set
            {
                this.Indexk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ItemNumber>k__BackingField", IsRequired=true)]
        public string ItemNumberk__BackingField
        {
            get
            {
                return this.ItemNumberk__BackingFieldField;
            }
            set
            {
                this.ItemNumberk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Name>k__BackingField", IsRequired=true)]
        public string Namek__BackingField
        {
            get
            {
                return this.Namek__BackingFieldField;
            }
            set
            {
                this.Namek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Outline>k__BackingField", IsRequired=true)]
        public string Outlinek__BackingField
        {
            get
            {
                return this.Outlinek__BackingFieldField;
            }
            set
            {
                this.Outlinek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ProductLine>k__BackingField", IsRequired=true)]
        public string ProductLinek__BackingField
        {
            get
            {
                return this.ProductLinek__BackingFieldField;
            }
            set
            {
                this.ProductLinek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Silhouette>k__BackingField", IsRequired=true)]
        public string Silhouettek__BackingField
        {
            get
            {
                return this.Silhouettek__BackingFieldField;
            }
            set
            {
                this.Silhouettek__BackingFieldField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Color", Namespace="http://schemas.datacontract.org/2004/07/AllfleXML.FlexSpec")]
    public partial class Color : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ColorCodek__BackingFieldField;
        
        private string DestronCodek__BackingFieldField;
        
        private string HexCodek__BackingFieldField;
        
        private string Namek__BackingFieldField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ColorCode>k__BackingField", IsRequired=true)]
        public string ColorCodek__BackingField
        {
            get
            {
                return this.ColorCodek__BackingFieldField;
            }
            set
            {
                this.ColorCodek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<DestronCode>k__BackingField", IsRequired=true)]
        public string DestronCodek__BackingField
        {
            get
            {
                return this.DestronCodek__BackingFieldField;
            }
            set
            {
                this.DestronCodek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<HexCode>k__BackingField", IsRequired=true)]
        public string HexCodek__BackingField
        {
            get
            {
                return this.HexCodek__BackingFieldField;
            }
            set
            {
                this.HexCodek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Name>k__BackingField", IsRequired=true)]
        public string Namek__BackingField
        {
            get
            {
                return this.Namek__BackingFieldField;
            }
            set
            {
                this.Namek__BackingFieldField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Face", Namespace="http://schemas.datacontract.org/2004/07/AllfleXML.FlexSpec")]
    public partial class Face : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string Namek__BackingFieldField;
        
        private string Outlinek__BackingFieldField;
        
        private AllfleXML.FlexSpec.Variable[] Variablesk__BackingFieldField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Name>k__BackingField", IsRequired=true)]
        public string Namek__BackingField
        {
            get
            {
                return this.Namek__BackingFieldField;
            }
            set
            {
                this.Namek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Outline>k__BackingField", IsRequired=true)]
        public string Outlinek__BackingField
        {
            get
            {
                return this.Outlinek__BackingFieldField;
            }
            set
            {
                this.Outlinek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Variables>k__BackingField", IsRequired=true)]
        public AllfleXML.FlexSpec.Variable[] Variablesk__BackingField
        {
            get
            {
                return this.Variablesk__BackingFieldField;
            }
            set
            {
                this.Variablesk__BackingFieldField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Variable", Namespace="http://schemas.datacontract.org/2004/07/AllfleXML.FlexSpec")]
    public partial class Variable : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CopyValueFromk__BackingFieldField;
        
        private string CurveTextAttachTok__BackingFieldField;
        
        private string DefaultValuek__BackingFieldField;
        
        private string Descriptionk__BackingFieldField;
        
        private string FontFacek__BackingFieldField;
        
        private string FontSizek__BackingFieldField;
        
        private int Heightk__BackingFieldField;
        
        private int Indexk__BackingFieldField;
        
        private bool IsCenteredk__BackingFieldField;
        
        private bool IsFixedk__BackingFieldField;
        
        private bool IsInkk__BackingFieldField;
        
        private bool IsLaserk__BackingFieldField;
        
        private string LogoImageLocationk__BackingFieldField;
        
        private int MaxLengthk__BackingFieldField;
        
        private string Namek__BackingFieldField;
        
        private int PositionXk__BackingFieldField;
        
        private int PositionYk__BackingFieldField;
        
        private System.Nullable<int> Radiusk__BackingFieldField;
        
        private string Rolek__BackingFieldField;
        
        private string Typek__BackingFieldField;
        
        private string ValueFormatk__BackingFieldField;
        
        private int Widthk__BackingFieldField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<CopyValueFrom>k__BackingField", IsRequired=true)]
        public string CopyValueFromk__BackingField
        {
            get
            {
                return this.CopyValueFromk__BackingFieldField;
            }
            set
            {
                this.CopyValueFromk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<CurveTextAttachTo>k__BackingField", IsRequired=true)]
        public string CurveTextAttachTok__BackingField
        {
            get
            {
                return this.CurveTextAttachTok__BackingFieldField;
            }
            set
            {
                this.CurveTextAttachTok__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<DefaultValue>k__BackingField", IsRequired=true)]
        public string DefaultValuek__BackingField
        {
            get
            {
                return this.DefaultValuek__BackingFieldField;
            }
            set
            {
                this.DefaultValuek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Description>k__BackingField", IsRequired=true)]
        public string Descriptionk__BackingField
        {
            get
            {
                return this.Descriptionk__BackingFieldField;
            }
            set
            {
                this.Descriptionk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<FontFace>k__BackingField", IsRequired=true)]
        public string FontFacek__BackingField
        {
            get
            {
                return this.FontFacek__BackingFieldField;
            }
            set
            {
                this.FontFacek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<FontSize>k__BackingField", IsRequired=true)]
        public string FontSizek__BackingField
        {
            get
            {
                return this.FontSizek__BackingFieldField;
            }
            set
            {
                this.FontSizek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Height>k__BackingField", IsRequired=true)]
        public int Heightk__BackingField
        {
            get
            {
                return this.Heightk__BackingFieldField;
            }
            set
            {
                this.Heightk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Index>k__BackingField", IsRequired=true)]
        public int Indexk__BackingField
        {
            get
            {
                return this.Indexk__BackingFieldField;
            }
            set
            {
                this.Indexk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<IsCentered>k__BackingField", IsRequired=true)]
        public bool IsCenteredk__BackingField
        {
            get
            {
                return this.IsCenteredk__BackingFieldField;
            }
            set
            {
                this.IsCenteredk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<IsFixed>k__BackingField", IsRequired=true)]
        public bool IsFixedk__BackingField
        {
            get
            {
                return this.IsFixedk__BackingFieldField;
            }
            set
            {
                this.IsFixedk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<IsInk>k__BackingField", IsRequired=true)]
        public bool IsInkk__BackingField
        {
            get
            {
                return this.IsInkk__BackingFieldField;
            }
            set
            {
                this.IsInkk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<IsLaser>k__BackingField", IsRequired=true)]
        public bool IsLaserk__BackingField
        {
            get
            {
                return this.IsLaserk__BackingFieldField;
            }
            set
            {
                this.IsLaserk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<LogoImageLocation>k__BackingField", IsRequired=true)]
        public string LogoImageLocationk__BackingField
        {
            get
            {
                return this.LogoImageLocationk__BackingFieldField;
            }
            set
            {
                this.LogoImageLocationk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<MaxLength>k__BackingField", IsRequired=true)]
        public int MaxLengthk__BackingField
        {
            get
            {
                return this.MaxLengthk__BackingFieldField;
            }
            set
            {
                this.MaxLengthk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Name>k__BackingField", IsRequired=true)]
        public string Namek__BackingField
        {
            get
            {
                return this.Namek__BackingFieldField;
            }
            set
            {
                this.Namek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<PositionX>k__BackingField", IsRequired=true)]
        public int PositionXk__BackingField
        {
            get
            {
                return this.PositionXk__BackingFieldField;
            }
            set
            {
                this.PositionXk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<PositionY>k__BackingField", IsRequired=true)]
        public int PositionYk__BackingField
        {
            get
            {
                return this.PositionYk__BackingFieldField;
            }
            set
            {
                this.PositionYk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Radius>k__BackingField", IsRequired=true)]
        public System.Nullable<int> Radiusk__BackingField
        {
            get
            {
                return this.Radiusk__BackingFieldField;
            }
            set
            {
                this.Radiusk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Role>k__BackingField", IsRequired=true)]
        public string Rolek__BackingField
        {
            get
            {
                return this.Rolek__BackingFieldField;
            }
            set
            {
                this.Rolek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Type>k__BackingField", IsRequired=true)]
        public string Typek__BackingField
        {
            get
            {
                return this.Typek__BackingFieldField;
            }
            set
            {
                this.Typek__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ValueFormat>k__BackingField", IsRequired=true)]
        public string ValueFormatk__BackingField
        {
            get
            {
                return this.ValueFormatk__BackingFieldField;
            }
            set
            {
                this.ValueFormatk__BackingFieldField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Width>k__BackingField", IsRequired=true)]
        public int Widthk__BackingField
        {
            get
            {
                return this.Widthk__BackingFieldField;
            }
            set
            {
                this.Widthk__BackingFieldField = value;
            }
        }
    }
}
