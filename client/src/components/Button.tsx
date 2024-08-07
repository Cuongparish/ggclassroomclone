import { Button, ConfigProvider } from "antd";
import { TinyColor } from '@ctrl/tinycolor';

export interface ButtonProp {
    name: string,
    onClick?: (event: React.MouseEvent<HTMLButtonElement>) => void,
    className?: string,
    htmlType?: 'button' | 'submit' | 'reset';
}

const PrimaryButton = (prop: ButtonProp) => {
    const colors1 = ['#24243E', '#59599B', '#0F0C29'];

    const getHoverColors = (colors: string[]) =>
        colors.map((color) => new TinyColor(color).lighten(5).toString());
    const getActiveColors = (colors: string[]) =>
        colors.map((color) => new TinyColor(color).darken(5).toString());


    return (
        <ConfigProvider
            theme={{
                components: {
                    Button: {
                        colorPrimary: `linear-gradient(135deg, ${colors1.join(', ')})`,
                        colorPrimaryHover: `linear-gradient(135deg, ${getHoverColors(colors1).join(', ')})`,
                        colorPrimaryActive: `linear-gradient(135deg, ${getActiveColors(colors1).join(', ')})`,
                        lineWidth: 0,
                    },
                },
            }}
        >
            <Button type="primary" className={`w-40 h-12 text-lg ${prop.className}`} onClick={prop.onClick} htmlType={prop.htmlType}>
                {prop.name}
            </Button>
        </ConfigProvider>
    );

}

const GoogleButton = (prop: ButtonProp) => {
    return (
        <ConfigProvider
            theme={{
                components: {
                    Button: {
                        colorPrimary: `#DB4437`,
                        colorPrimaryHover: `#BD2E22`,
                        colorPrimaryActive: `#BD2E22`,
                        lineWidth: 0,
                    },
                },
            }}
        >
            <Button type="primary" className="w-40 h-12 text-lg" onClick={prop.onClick}>
                {prop.name}
            </Button>
        </ConfigProvider>
    );

}

const FaceBookButton = (prop: ButtonProp) => {
    return (
        <ConfigProvider
            theme={{
                components: {
                    Button: {
                        colorPrimary: `#4267B2`,
                        colorPrimaryHover: `#6283C5`,
                        colorPrimaryActive: `#6283C5`,
                        lineWidth: 0,
                    },
                },
            }}
        >
            <Button type="primary" className="w-40 h-12 text-lg" onClick={prop.onClick}>
                {prop.name}
            </Button>
        </ConfigProvider>
    );

}


const UploadButton = (prop: ButtonProp) => {
    const colors = ['#1D72E8', '#0D47A1'];

    const getHoverColors = (colors: string[]) =>
        colors.map((color) => new TinyColor(color).lighten(5).toString());
    const getActiveColors = (colors: string[]) =>
        colors.map((color) => new TinyColor(color).darken(5).toString());

    return (
        <ConfigProvider
            theme={{
                components: {
                    Button: {
                        colorPrimary: `linear-gradient(135deg, ${colors.join(', ')})`,
                        colorPrimaryHover: `linear-gradient(135deg, ${getHoverColors(colors).join(', ')})`,
                        colorPrimaryActive: `linear-gradient(135deg, ${getActiveColors(colors).join(', ')})`,
                        lineWidth: 0,
                    },
                },
            }}
        >
            <Button type="primary" className={`${prop.className}`} onClick={prop.onClick}>
                {prop.name}
            </Button>
        </ConfigProvider>
    );
};

const DownloadButton = (prop: ButtonProp) => {
    const colors = ['#28A745', '#218838'];

    const getHoverColors = (colors: string[]) =>
        colors.map((color) => new TinyColor(color).lighten(5).toString());
    const getActiveColors = (colors: string[]) =>
        colors.map((color) => new TinyColor(color).darken(5).toString());

    return (
        <ConfigProvider
            theme={{
                components: {
                    Button: {
                        colorPrimary: `linear-gradient(135deg, ${colors.join(', ')})`,
                        colorPrimaryHover: `linear-gradient(135deg, ${getHoverColors(colors).join(', ')})`,
                        colorPrimaryActive: `linear-gradient(135deg, ${getActiveColors(colors).join(', ')})`,
                        lineWidth: 0,
                    },
                },
            }}
        >
            <Button type="primary" className={`${prop.className}`} onClick={prop.onClick}>
                {prop.name}
            </Button>
        </ConfigProvider>
    );
};

export { PrimaryButton, GoogleButton, FaceBookButton, UploadButton, DownloadButton };